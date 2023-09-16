using NJM.Application.UI;
using NJM.Core.Assets;
using NJM.Core.Events;

namespace NJM.Business.Game.Internal;

public class GameContext {

    UIApp uiApp;
    public UIApp UIApp => uiApp;

    AssetsCore assetsCore;
    public AssetsCore AssetsCore => assetsCore;

    EventsCore eventsCore;
    public EventsCore EventsCore => eventsCore;

    GameRoleRepo roleRepo;
    public GameRoleRepo RoleRepo => roleRepo;

    public GameContext() {
        this.roleRepo = new GameRoleRepo();
    }

    public void Inject(UIApp uiApp, AssetsCore assetsCore, EventsCore eventsCore) {
        this.uiApp = uiApp;
        this.assetsCore = assetsCore;
        this.eventsCore = eventsCore;
    }

}