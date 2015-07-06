using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}