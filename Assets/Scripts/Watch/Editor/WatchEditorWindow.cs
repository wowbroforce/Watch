using UnityEditor;
using UnityEngine;

public class WatchEditorWindow : EditorWindow
{
    private const string TITLE = "Watch";
	private WatchContext _context;
	private Vector2 _scrollPosition;

	[MenuItem("Window/Watch")]
	private static void Init() {
		var window = CreateInstance<WatchEditorWindow>();
	    window.title = TITLE;
		window.Show();
	}

	private void OnEnable() {
		_context = WatchContext.instance;
	}

	private void OnGUI() {
		EditorGUILayout.BeginVertical();
		_scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);
		_context.ForEach((key, value) => EditorGUILayout.LabelField(key, value));
		EditorGUILayout.EndScrollView();
		EditorGUILayout.EndVertical();
	}

	private void Update() {
		if (EditorApplication.isPlaying && !EditorApplication.isPaused) {
			Repaint();
		}
	}
}
