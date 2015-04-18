using UnityEngine;

public static class Watch {
    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Show(string key, string message) {
        if (string.IsNullOrEmpty(key))
            return;
        WatchContext.instance.AddMessage(key, message);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void ShowFormat(string key, string format, params object[] args) {
        if (string.IsNullOrEmpty(key)) {
            return;
        }

        WatchContext.instance.AddMessage(key, string.Format(format, args));
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Log(object message) {
        Debug.Log(message);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Log(object message, Object context) {
        Debug.Log(message, context);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogError(object message) {
        Debug.LogError(message);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogError(object message, Object context) {
        Debug.LogError(message, context);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(string format, params object[] args) {
        Debug.LogErrorFormat(format, args);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(Object context, string format, params object[] args) {
        Debug.LogErrorFormat(context, format, args);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception) {
        Debug.LogException(exception);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception, Object context) {
        Debug.LogException(exception, context);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogFormat(string format, params object[] args) {
        Debug.LogFormat(format, args);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogFormat(Object context, string format, params object[] args) {
        Debug.LogFormat(context, format, args);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message) {
        Debug.LogWarning(message);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, Object context) {
        Debug.LogWarning(message, context);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(string format, params object[] args) {
        Debug.LogWarningFormat(format, args);
    }

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(Object context, string format, params object[] args) {
        Debug.LogWarningFormat(context, format, args);
    }
}
