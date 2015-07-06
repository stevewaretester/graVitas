using UnityEngine;
using System;
using System.Collections;
 

public class Spawner : MonoBehaviour {
	
	private Vector3 spawnLocation;
	private GameObject drone;
	private int timer = 0;
	private int counter;
	
	
	// Use this for initialization
	void Start () {
		
	counter = 0;
			
	spawnLocation = new Vector3(0f, 90f, 0f);
		
	// Sets drone to be the spawning object		
	drone = GameObject.CreatePrimitive(PrimitiveType.Cube);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Update the timer every frame
		timer = timer + (int)Time.deltaTime;
		
		// Is the time a multiple of 10?
		if (timer % 10 == 0 && counter < 4) {
		
		counter++;	
		spawnDrone();
		
	
		}
	
	
	}
	
	void spawnDrone() {
			
		    
		GameObject clone;
		spawnLocation = new Vector3(0f, 90 + counter * 5f, 0f);
		clone = Instantiate(drone, spawnLocation, Quaternion.identity) as GameObject;
		
		if (clone.GetComponent("Drone") != true )
		{
			
			clone.AddComponent("Drone");
			
		}

		
	}
	
	
	
}
