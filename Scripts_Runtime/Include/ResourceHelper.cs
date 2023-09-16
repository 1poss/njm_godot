using System.IO;
using System.Collections.Generic;
using Godot;

public static class ResourceHelper {

    // 加载目录下的所有.tscn(即Unity的.prefab)
    // dirPath: 传入 res:// 的路径, 例如: res://Roles
    public static List<PackedScene> LoadAllScenes(string dirPath, bool isInclueRecurseDir) {
        using var dir = DirAccess.Open(dirPath);
        var scenes = new List<PackedScene>();
        Error err = DirAccess.GetOpenError();
        if (err == Error.Ok) {
            err = dir.ListDirBegin();
            while (true) {
                var file = dir.GetNext();
                if (file == "") {
                    break;
                }
                var filePath = Path.Join(dir.GetCurrentDir(), file);
                if (dir.CurrentIsDir()) {
                    if (isInclueRecurseDir) {
                        scenes.AddRange(LoadAllScenes(filePath, isInclueRecurseDir));
                    }
                } else {
                    if (filePath.Contains(".tscn.remap")) {
                        filePath = filePath.Replace(".remap", "");
                    }
                    var scene = GD.Load<PackedScene>(filePath);
                    if (scene != null) {
                        scenes.Add(scene);
                    }
                }
            }
            dir.ListDirEnd();
        } else {
            GD.PrintErr("ResourceHelper.LoadAllScenes:" + err.ToString());
        }
        return scenes;
    }

}