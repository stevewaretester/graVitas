using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public float lifetime = 2.0f;
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, lifetime);
	}
}
