using System;
using Godot;
using NJM.CoreAssets;
using NJM.ApplicationUI;
using NJM.BusinessLogin;

namespace NJM.MainEntry {

    public partial class ClientMain : Node {

        [Export] public Control canvasNode;

        UIApp uiApp;

        AssetsCore assetsCore;

        LoginBusiness loginBusiness;

        public override void _Ready() {

            // ==== Ctor ====
            try {

                uiApp = new UIApp();
                assetsCore = new AssetsCore();
                loginBusiness = new LoginBusiness();

                // ==== Inject ====
                uiApp.Inject(canvasNode, assetsCore.PanelAssets);
                loginBusiness.Inject(uiApp);

                // ==== Init ====
                assetsCore.LoadAll();

                // ==== Enter ====
                loginBusiness.Enter();

            } catch (Exception ex) {

                GD.PrintErr(ex);
                
            }

        }

        public override void _Process(double delta) {

        }

        public override void _Notification(int what) {
            if (what == NotificationWMCloseRequest) {
                GD.Print("ClientMain: WM Close Request");
                assetsCore.Clear();
                GetTree().Quit();
            }
        }

    }
}
