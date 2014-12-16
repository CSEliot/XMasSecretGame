using UnityEngine;
using System.Collections;

public class TurnControl : MonoBehaviour {

	float turnAmountX = 0f;
	float turnAmountZ = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		turnAmountX = Input.GetAxis ("Horizontal");
		turnAmountZ = Input.GetAxis ("Vertical");
		transform.localEulerAngles = new Vector3 (90f * turnAmountZ, 0, 90f * -1f*turnAmountX); 
	}
}
