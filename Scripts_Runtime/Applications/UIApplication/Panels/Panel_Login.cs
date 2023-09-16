using Godot;
using System;

namespace NJM.ApplicationUI {

    public partial class Panel_Login : Control, IUIPanel {

        [Export] public Button btnStart;

        public void Ctor() {
            btnStart.ButtonUp += OnBtnStartButtonUp;
        }

        void OnBtnStartButtonUp() {
            GD.Print("Start button pressed");
        }

    }

}
