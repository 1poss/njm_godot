using Godot;
using NJM.Core.Events;
using NJM.Application.UI;

namespace NJM.Business.Game;

public class GameBusiness {

    UIApp uiApp;
    EventsCore eventsCore;

    public GameBusiness() { }

    public void Inject(UIApp uiApp, EventsCore eventsCore) {
        this.uiApp = uiApp;
        this.eventsCore = eventsCore;
    }

    public void Enter() {
        GD.Print("StartGame");
    }

}