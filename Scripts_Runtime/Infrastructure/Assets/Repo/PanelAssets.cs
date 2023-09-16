using System.IO;
using System.Collections.Generic;
using Godot;

namespace NJM.Core.Assets;

public class PanelAssets {

    const string DIR = "res://Assets/UI";

    Dictionary<string, PackedScene> all;

    public PanelAssets() {
        all = new Dictionary<string, PackedScene>();
    }

    public void LoadAll() {
        List<PackedScene> list = ResourceHelper.LoadAllScenes(DIR, false);
        foreach (var prefab in list) {
            all.Add(prefab.GetResouceNameWithoutExt(), prefab);
        }
    }

    public bool TryGet(string name, out PackedScene prefab) {
        return all.TryGetValue(name, out prefab);
    }

    public void Clear() {
        foreach (var kv in all) {
            kv.Value.Dispose();
        }
        all.Clear();
    }

}
