using UnityEngine;
using System.Collections;

public class RefuseOrbit : MonoBehaviour {

	public Transform target;
	//public Transform player;
	//public Vector3 point;
	public Vector3 axis;
	public float speed;
	Vector3 point;
	Vector3 oppositeAxis;



	// Use this for initialization

	void Awake()
	{
		//point = target.TransformPoint;
		point = target.transform.position;


	}


	void Start () {

	
	}
	
	// Update is called once per frame

	void FixedUpdate (){
		point = target.transform.position;
	}

	void Update () {
		//this.gameObject.RotateAround(point, axis, angle*Time.deltaTime);
		transform.RotateAround(point, axis, speed*Time.deltaTime);
		transform.Rotate (-axis, speed*Time.deltaTime);
	}
}
