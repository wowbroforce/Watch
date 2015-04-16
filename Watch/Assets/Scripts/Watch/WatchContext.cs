using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class WatchContext : ScriptableObject
{
	public static WatchContext instance {
		get {
			if (_instance == null) {
				_instance = Resources.FindObjectsOfTypeAll<WatchContext> ().FirstOrDefault ();
				if (_instance == null) {
					_instance = CreateInstance<WatchContext> ();
					_instance.hideFlags = HideFlags.DontSave;
				}
			}
			return _instance;
		}
	}

	private static WatchContext _instance;
	private readonly Dictionary<string, string> _messages = new Dictionary<string, string> ();
	private readonly List<WatchTuple<WeakReference, Func<object, string>>> _objects = new List<WatchTuple<WeakReference, Func<object, string>>> ();

	public void AddMessage (string key, string value)
	{
		_messages [key] = value;
	}

	public void AddObject (object target, Func<object, string> describe) {

		if (_objects.Where (o => o.item1.IsAlive).Select (o => o.item1.Target).Contains (target)) {
			return;
		}

		_objects.Add (WatchTuple.Create(new WeakReference(target), describe));
	}

	public void ForEach (WatchContextForEachDelegate action)
	{
//		foreach (var message in _messages) {
//			action (message.Key, message.Value);
//		}
		foreach (var obj in _objects) {
			if (obj.item1.IsAlive) {
				var target = obj.item1.Target;
				action (target.ToString (), obj.item2(target));
			}
		}
	}

	private void UpdateObjects() {
		_objects.RemoveAll (o => !o.item1.IsAlive);
	}

	private void OnEnable() {
		UpdateObjects ();
	}
}

public delegate void WatchContextForEachDelegate (string key,string value);
