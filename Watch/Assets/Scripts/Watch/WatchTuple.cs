using UnityEngine;
using System.Collections;

public static class WatchTuple
{
	public static WatchTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) {
		return new WatchTuple<T1, T2> (item1, item2);
	}
}

public sealed class WatchTuple<T1, T2>
{
	public T1 item1 {
		get {
			return _item1;
		}
	}

	public T2 item2 {
		get {
			return _item2;
		}
	}

	private readonly T1 _item1;
	private readonly T2 _item2;

	public WatchTuple (T1 item1, T2 item2)
	{
		_item1 = item1;
		_item2 = item2;
	}

	public override string ToString ()
	{
		return string.Format ("WatchTuple({0}, {1})", _item1, _item2);
	}

	public override int GetHashCode ()
	{
		int hash = 17;
		hash = hash * 23 + (_item1 == null ? 0 : item1.GetHashCode ());
		hash = hash * 23 + (_item2 == null ? 0 : item2.GetHashCode ());
		return hash;
	}

	public override bool Equals (object obj)
	{
		var watchTuple = obj as WatchTuple<T1, T2>;
		if (watchTuple == null) {
			return false;
		}

		var other = watchTuple;

		return this == other;
	}

	public bool Equals (WatchTuple<T1, T2> other)
	{
		return this == other;
	}

	public static bool operator== (WatchTuple<T1, T2> a, WatchTuple<T1, T2> b)
	{
		if (object.ReferenceEquals (a, null)) {
			return object.ReferenceEquals (b, null);
		}
		if (a.item1 == null && b.item1 != null)
			return false;
		if (a.item2 == null && b.item2 != null)
			return false;
		return a.item1.Equals (b.item1) && a.item2.Equals (b.item2);
	}

	public static bool operator!= (WatchTuple<T1, T2> a, WatchTuple<T1, T2> b)
	{
		return !(a == b);
	}
}