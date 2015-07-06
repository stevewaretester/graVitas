using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float currentSpeed = 10;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// Moves player left, right, up, down.
		// float x = Input.GetAxis("Horizontal") * Time.deltaTime * currentSpeed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * currentSpeed;
		transform.Translate(0,y,0,Space.Self);
	
			
			
	}
	
}
