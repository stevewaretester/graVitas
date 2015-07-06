using UnityEngine;
using System.Collections;

public class GlobeMove : MonoBehaviour {
	
	public float currentSpeed;
	public float rateOfAcceleration = 0.05f; 
	public float topSpeed = 75;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// Moves player left, right, up, down.
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * currentSpeed;
		
		// Spin upon it's axis
		transform.Rotate(0,x,0,Space.Self);
	
	

		if (currentSpeed < topSpeed) {
				currentSpeed = currentSpeed + rateOfAcceleration; 
		}
				
			
	}
	
}
