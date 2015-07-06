using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public float speed;
	public GameObject Bullet;
	public Transform shot_spawn;
	public float fireRate;
	private float nextFire;

	void Update() {
		if (Input.GetButton ("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Bullet, shot_spawn.position, shot_spawn.rotation);
		}
	}

	void FixedUpdate() {
		float movevertical = Input.GetAxis("Vertical") * speed;
		float movehorizontal = Input.GetAxis("Horizontal") * speed;
		movevertical *= Time.deltaTime;
		movehorizontal *= Time.deltaTime;
		transform.Translate(0, movevertical, 0);
		transform.Translate(movehorizontal, 0, 0);
	}
}


/*

using UnityEngine;
using System.Collections;

public class testing : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	void Update() {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}
}
*/