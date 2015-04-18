using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class WatchContext : ScriptableObject {
	public static WatchContext instance {
		get {
			if (_instance == null) {
				_instance = Resources.FindObjectsOfTypeAll<WatchContext>().FirstOrDefault();
				if (_instance == null) {
					_instance = CreateInstance<WatchContext>();
					_instance.hideFlags = HideFlags.DontSave;
				}
			}
			return _instance;
		}
	}

	private static WatchContext _instance;
	private readonly Dictionary<string, string> _messages = new Dictionary<string, string>();

	public void AddMessage(string key, string value) {
		_messages[key] = value;
	}

	public void ForEach(WatchContextForEachDelegate action) {
		foreach (var message in _messages) {
			action(message.Key, message.Value);
		}
	}
}

public delegate void WatchContextForEachDelegate(string key, string value);