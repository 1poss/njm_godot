using Godot;

namespace NJM.Core.Assets;

public class AssetsCore {

    PanelAssets panelAssets;
    public PanelAssets PanelAssets => panelAssets;

    GameAssets gameAssets;
    public GameAssets GameAssets => gameAssets;

    public AssetsCore() {
        panelAssets = new PanelAssets();
        gameAssets = new GameAssets();
    }

    public void LoadAll() {
        panelAssets.LoadAll();
        gameAssets.LoadAll();
    }

    public void Clear() {
        panelAssets.Clear();
        gameAssets.Clear();
    }

}
