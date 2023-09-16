using System;

namespace NJM.Core.Events;

public class EventsCore {

    public Action OnStartGameHandle;
    public void StartGame() {
        OnStartGameHandle.Invoke();
    }

    public EventsCore() {}

}