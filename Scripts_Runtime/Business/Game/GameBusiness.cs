using Godot;
using NJM.Core.Events;
using NJM.Core.Assets;
using NJM.Application.UI;
using NJM.Business.Game.Internal;

namespace NJM.Business.Game;

public class GameBusiness {

    GameContext gameContext;

    public GameBusiness() {
        this.gameContext = new GameContext();
    }

    public void Inject(UIApp uiApp, AssetsCore assetsCore, EventsCore eventsCore) {
        gameContext.Inject(uiApp, assetsCore, eventsCore);
    }

    public void Enter() {
        GD.Print("StartGame");
    }

}