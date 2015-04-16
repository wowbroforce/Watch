using UnityEditor;

public class WatchEditorWindow : EditorWindow {
    private WatchContext _context;

    [MenuItem("Window/Watch")]
    private static void Init() {
        var window = CreateInstance<WatchEditorWindow>();
        window.Show();
    }

    private void OnEnable() {
        _context = WatchContext.instance;
    }

    private void OnGUI() {
        EditorGUILayout.BeginVertical();
        _context.ForEach((key, value) => EditorGUILayout.LabelField(key, value));
        EditorGUILayout.EndVertical();
    }

    private void Update() {
        if (EditorApplication.isPlaying && !EditorApplication.isPaused) {
            Repaint();
        }
    }
}
