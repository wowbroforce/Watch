using UnityEngine;

public class WatchDemo : MonoBehaviour {

	void Start() {
		Watch.Log("start log", Time.time.ToString());
	}

	void Update() {		
		Watch.Log("update log", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 2", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 3", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 4", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 5", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 6", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 7", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 8", Time.timeSinceLevelLoad.ToString());
		Watch.Log("update log 9", Time.timeSinceLevelLoad.ToString());
	}
}
