using Godot;
using NJM.Core.Assets;
using NJM.Application.UI.Internal;

namespace NJM.Application.UI;

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