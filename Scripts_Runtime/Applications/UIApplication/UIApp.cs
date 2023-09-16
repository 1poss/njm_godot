using Godot;
using NJM.CoreAssets;

namespace NJM.ApplicationUI {

    public class UIApp {

        UIFactory factory;
        UIRepo repo;

        UILoginDomain loginDomain;
        public UILoginDomain LoginDomain => loginDomain;

        public UIApp() {
            factory = new UIFactory();
            repo = new UIRepo();
            loginDomain = new UILoginDomain();
        }

        public void Inject(Node canvasNode, PanelAssets panelAssets) {
            factory.Inject(canvasNode, repo, panelAssets);
            loginDomain.Inject(factory);
        }

    }

}