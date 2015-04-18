public static class Watch {
	[System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
	public static void Show(string key, string message) {
        if (string.IsNullOrEmpty(key))
			return;
		WatchContext.instance.AddMessage(key, message);
	}

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void ShowFormat(string key, string format, params object[] parameters)
    {
        if (string.IsNullOrEmpty(key))
        {
            return;
        }
        WatchContext.instance.AddMessage(key, string.Format(format, parameters));
    }
}
