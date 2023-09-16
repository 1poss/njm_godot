using Godot;
using System;
using NJM.ApplicationUI;

namespace NJM.BusinessLogin {

    public class LoginBusiness {

        UIApp uiApp;

        public LoginBusiness() {}

        public void Inject(UIApp uiApp) {
            this.uiApp = uiApp;
        }

        public void Enter() {
            uiApp.LoginDomain.Open();
        }

    }

}
