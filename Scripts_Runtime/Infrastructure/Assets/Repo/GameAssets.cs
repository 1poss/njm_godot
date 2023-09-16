using System.Collections.Generic;
using Godot;

namespace NJM.Core.Assets;

public class GameAssets {

    const string DIR = "res://Assets/Game";

    Dictionary<string, PackedScene> all;    

    public GameAssets() {
        this.all = new Dictionary<string, PackedScene>();
    }

    public void LoadAll() {
        List<PackedScene> list = ResourceHelper.LoadAllScenes(DIR, false);
        foreach (var prefab in list) {
            all.Add(prefab.GetResouceNameWithoutExt(), prefab);
        }
    }

    public PackedScene GetRolePrefab() {
        bool has = all.TryGetValue("go_role", out var prefab);
        if (!has) {
            PLog.Error("No Role Prefab");
            return null;
        }
        return prefab;
    }

    public void Clear() {
        foreach (var kv in all) {
            kv.Value.Dispose();
        }
        all.Clear();
    }

}