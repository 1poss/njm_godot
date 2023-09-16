using System.IO;
using Godot;

public static class PackedSceneExtension {

    public static string GetResouceNameWithoutExt(this PackedScene scene) {
        return Path.GetFileName(scene.ResourcePath).Replace(".tscn", "");
    }
}