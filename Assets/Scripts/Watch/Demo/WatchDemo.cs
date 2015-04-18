using System.Globalization;
using UnityEngine;
using System.Linq;

public class WatchDemo : MonoBehaviour
{
    public Rigidbody2D[] balls;
    public float force = 10;

	void Start() {
        balls.ToList().ForEach(r => r.AddForce(Random.insideUnitCircle * force, ForceMode2D.Impulse));
	}

	void Update() {
        balls.ToList().ForEach(r => Watch.Log("velocity of " + r.gameObject.name, r.velocity.magnitude.ToString(CultureInfo.InvariantCulture)));
	}
}
