using UnityEngine;
using System.Collections;

public class MakeForce : MonoBehaviour {

	float rotateZ;
	public Rigidbody body;
	public float forceAmount = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetAxis ("BoostOn") > 0) {
			body.AddForceAtPosition (transform.forward * -forceAmount, transform.position, ForceMode.Force);
			transform.GetChild (0).gameObject.SetActive (true);
		} else {
			transform.GetChild (0).gameObject.SetActive (false);
		}
		//rigidbody.AddRelativeForce (transform.forward);
	}
}
