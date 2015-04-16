using UnityEngine;

public class WatchDemo : MonoBehaviour {

	void Start () {
		Watch.Log ("start log", Time.time.ToString());
	}
	
	void Update () {
		Watch.Log ("update log", Time.timeSinceLevelLoad.ToString());
	}
}
