using Godot;
using NJM.CoreAssets;

namespace NJM.ApplicationUI {

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

        public T OpenUnique<T>() where T : Control, IUIPanel {
            string typeName = typeof(T).Name;
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

    }

}