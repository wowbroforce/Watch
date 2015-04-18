using System.Globalization;
using UnityEngine;
using System.Linq;

public class WatchDemo : MonoBehaviour
{
    public Rigidbody2D[] balls;
    public float force = 10;

	void Start() {
        Watch.ShowFormat("info", "balls count = {0}, force = {1}", balls.Length, force);
        balls.ToList().ForEach(r => r.AddForce(Random.insideUnitCircle * force, ForceMode2D.Impulse));
	}

	void Update() {
        balls.ToList().ForEach(r => Watch.Show(r.gameObject.name, r.velocity.magnitude.ToString(CultureInfo.InvariantCulture)));
	}
}
