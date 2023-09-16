using Godot;
using NJM.CoreAssets;

namespace NJM.ApplicationUI {

    public class UILoginDomain {

        UIFactory factory;

        public UILoginDomain() { }

        public void Inject(UIFactory factory) {
            this.factory = factory;
        }

        public void Open() {
            var panel = factory.OpenUnique<Panel_Login>();
            panel.Ctor();
        }

    }

}