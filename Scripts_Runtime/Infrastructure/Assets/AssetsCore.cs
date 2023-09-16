using Godot;

namespace NJM.CoreAssets {

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

}