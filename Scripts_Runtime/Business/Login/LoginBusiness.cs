using Godot;
using System;
using NJM.Application.UI;
using NJM.Core.Events;

namespace NJM.Business.Login;

public class LoginBusiness {

    UIApp uiApp;
    EventsCore eventsCore;

    public LoginBusiness() { }

    public void Inject(UIApp uiApp, EventsCore eventsCore) {
        this.uiApp = uiApp;
        this.eventsCore = eventsCore;
    }

    public void Enter() {
        uiApp.LoginDomain.Open(OnStartGame);
    }

    void OnStartGame() {
        uiApp.LoginDomain.Close();
        eventsCore.StartGame();
    }

}
