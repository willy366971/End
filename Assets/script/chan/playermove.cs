using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("forward", Input.GetAxis ("Vertical"));
		anim.SetBool ("run", Input.GetKey (KeyCode.W));
	}
}
