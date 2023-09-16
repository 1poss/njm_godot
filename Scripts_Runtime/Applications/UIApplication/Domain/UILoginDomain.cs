using System;
using Godot;
using NJM.Application.UI.Internal;

namespace NJM.Application.UI;

public class UILoginDomain {

    UIFactory factory;

    public UILoginDomain() { }

    public void Inject(UIFactory factory) {
        this.factory = factory;
    }

    public void Open(Action onStartGameHandle) {
        var panel = factory.OpenUnique<Panel_Login>();
        panel.Ctor();
        panel.OnStartGameHandle = onStartGameHandle;
    }

    public void Close() {
        factory.Close<Panel_Login>();
    }

}
