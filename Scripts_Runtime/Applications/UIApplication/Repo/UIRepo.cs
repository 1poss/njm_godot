using System.Collections.Generic;

namespace NJM.ApplicationUI {

    public class UIRepo {

        Dictionary<string, IUIPanel> uniques;

        public UIRepo() {
            this.uniques = new Dictionary<string, IUIPanel>();
        }

        public void AddUnique(string name, IUIPanel panel) {
            uniques.Add(name, panel);
        }

    }

}