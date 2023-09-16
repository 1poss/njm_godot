using Godot;
using System;

namespace NJM.Application.UI.Internal;

public partial class Panel_Login : Control, IUIPanel {

    [Export] public Button btnStart;

    public Action OnStartGameHandle;

    public void Ctor() {
        btnStart.ButtonUp += OnBtnStartButtonUp;
    }

    public void TearDown() {
        btnStart.ButtonUp -= OnBtnStartButtonUp;
        OnStartGameHandle = null;
    }

    void OnBtnStartButtonUp() {
        OnStartGameHandle.Invoke();
        GD.Print("Start button pressed");
    }

}
