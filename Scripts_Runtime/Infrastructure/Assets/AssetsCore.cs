using Godot;

namespace NJM.Core.Assets;

public class AssetsCore {

    PanelAssets panelAssets;
    public PanelAssets PanelAssets => panelAssets;

    public AssetsCore() {
        panelAssets = new PanelAssets();
    }

    public void LoadAll() {
        panelAssets.LoadAll();
    }

    public void Clear() {
        panelAssets.Clear();
    }

}
