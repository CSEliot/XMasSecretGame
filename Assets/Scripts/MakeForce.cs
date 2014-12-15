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
		//rigidbody.AddRelativeForce (transform.forward);
		body.AddForceAtPosition (transform.forward*-forceAmount,transform.position, ForceMode.Force);
	}
}
