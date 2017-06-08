using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
	public float speed,angle;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody>().AddForce(0, 300, 0);
        }
        if (Input.GetKey (KeyCode.W)) {
			transform.Translate(0, 0, Time.deltaTime*speed);
        }
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(0, 0, -Time.deltaTime*speed);
				
		}
		if (Input.GetKey (KeyCode.D)) {

			transform.Rotate(new Vector3(0,angle,0));
		}
		if (Input.GetKey (KeyCode.A)) {

			transform.Rotate(new Vector3(0,-angle,0));	
		} 
		if (anim.GetBool("run") == true) {
			speed = 5;
		}
		else{
			speed = 2;
		}
       
    }

    void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick")) {
			other.gameObject.SetActive (false);
		}
	}
    
}
