public static class Watch {
    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Log(string key, string message) {
        if (string.IsNullOrEmpty(key))
            return;

        WatchContext.instance.AddMessage(key, message);
    }
}
