using Godot;
using NJM.Core.Assets;

namespace NJM.Application.UI.Internal;

public class UIFactory {

    Node canvasNode;
    UIRepo repo;
    PanelAssets panelAssets;

    public UIFactory() { }

    public void Inject(Node canvasNode, UIRepo repo, PanelAssets panelAssets) {
        this.canvasNode = canvasNode;
        this.repo = repo;
        this.panelAssets = panelAssets;
    }

    public T GetUnique<T>() where T : Control, IUIPanel {
        string typeName = GetTypeName<T>();
        bool has = repo.TryGetUnique(typeName, out var panel);
        if (!has) {
            GD.PrintErr($"UIFactory.GetUnique<{typeName}>: panel not found");
            return null;
        }
        return (T)panel;
    }

    public T OpenUnique<T>() where T : Control, IUIPanel {
        string typeName = GetTypeName<T>();
        bool has = panelAssets.TryGet(typeName, out var prefab);
        if (!has) {
            GD.PrintErr($"UIFactory.OpenUnique<{typeName}>: prefab not found");
            return null;
        }
        var go = prefab.Instantiate<T>();
        canvasNode.AddChild(go);
        repo.AddUnique(typeName, go);
        return go;
    }

    public void Close<T>() where T : Control, IUIPanel {
        string typeName = GetTypeName<T>();
        bool has = repo.TryGetUnique(typeName, out var panel);
        if (!has) {
            GD.PrintErr($"UIFactory.Close<{typeName}>: panel not found");
            return;
        }
        Control control = (Control)panel;
        control.QueueFree();
        repo.RemoveUnique(typeName);
    }

    static string GetTypeName<T>() {
        return typeof(T).Name.ToLower();
    }

}
