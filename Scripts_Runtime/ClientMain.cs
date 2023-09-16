using System;
using Godot;
using NJM.Core.Assets;
using NJM.Core.Events;
using NJM.Application.UI;
using NJM.Business.Login;
using NJM.Business.Game;

namespace NJM.MainEntry;

public partial class ClientMain : Node {

    [Export] public Control canvasNode;

    UIApp uiApp;

    AssetsCore assetsCore;

    EventsCore eventsCore;

    LoginBusiness loginBusiness;
    GameBusiness gameBusiness;

    public override void _Ready() {

        try {

            // ==== Ctor ====
            uiApp = new UIApp();

            assetsCore = new AssetsCore();
            eventsCore = new EventsCore();

            loginBusiness = new LoginBusiness();
            gameBusiness = new GameBusiness();

            // ==== Inject ====
            uiApp.Inject(canvasNode, assetsCore.PanelAssets);
            loginBusiness.Inject(uiApp, eventsCore);
            gameBusiness.Inject(uiApp, assetsCore, eventsCore);

            // ==== Init ====
            // - Assets
            assetsCore.LoadAll();

            // - Events
            eventsCore.OnStartGameHandle += () => {
                gameBusiness.Enter();
            };

            // ==== Enter ====
            loginBusiness.Enter();

        } catch (Exception ex) {

            GD.PrintErr(ex);

        }

    }

    public override void _Process(double delta) {

    }

    public override void _Notification(int what) {

        // Windows close request
        if (what == NotificationWMCloseRequest) {
            TearDown();
        }

        // Android back button
        if (what == NotificationApplicationPaused) {

        } else if (what == NotificationApplicationResumed) {

        }
    }

    void TearDown() {
        assetsCore.Clear();
        GetTree().Quit();
    }

}