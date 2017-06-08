using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour {

	public Transform lookAtObj;
	// Update is called once per frame
	void Update () {
		// look at player
		transform.LookAt(lookAtObj);    
	}
}
