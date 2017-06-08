using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	Rigidbody playerRigidbody;
	float moveX;
	float moveZ;
	public float speed;

	// Use this for initialization
	void Awake () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		MovementController ();
	}
	void Move(){
		moveX = Input.GetAxis ("Horizontal");
		moveZ = Input.GetAxis ("Vertical");
		playerRigidbody.AddForce (new Vector3 (speed * moveX, 0, speed * moveZ));
	}
	void MovementController(){
		if (!talk.isTalking) 
		{
			Move ();
		}
	}
}
