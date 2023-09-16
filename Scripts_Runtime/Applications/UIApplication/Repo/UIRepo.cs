using System.Collections.Generic;

namespace NJM.Application.UI.Internal;

public class UIRepo {

    Dictionary<string, IUIPanel> uniques;

    public UIRepo() {
        this.uniques = new Dictionary<string, IUIPanel>();
    }

    public void AddUnique(string name, IUIPanel panel) {
        uniques.Add(name, panel);
    }

    public bool TryGetUnique(string name, out IUIPanel panel) {
        return uniques.TryGetValue(name, out panel);
    }

    public void RemoveUnique(string name) {
        uniques.Remove(name);
    }

}
