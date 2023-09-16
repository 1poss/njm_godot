using Godot;

public static class PLog {

    public static void Log(object message) {
        GD.Print(message);
    }

    public static void Error(object message) {
        GD.PrintErr(message);
    }
}