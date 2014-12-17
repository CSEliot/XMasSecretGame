using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MakeForce : MonoBehaviour {

	float rotateZ;
	public Rigidbody body;
    //public AudioClip boostNoise;
	public float forceAmount;
    public float megaBoostAmount;
    private string boosterName;
    private string megaBoostName;
	// Use this for initialization
	void Start () {
        if (gameObject.name == "Rocket1")
        {
            boosterName = "Booster1";
            megaBoostName = "MegaBoost1";
        }
        else if (gameObject.name == "Rocket2")
        {
            boosterName = "Booster2";
            megaBoostName = "MegaBoost2";
        }
        else if (gameObject.name == "Rocket3")
        {
            boosterName = "Booster3";
            megaBoostName = "MegaBoost3";
        }
        else if (gameObject.name == "Rocket4")
        {
            boosterName = "Booster4";
            megaBoostName = "MegaBoost4";
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetAxis(megaBoostName) > 0 || Input.GetAxis("MegaBoostOn") > 0)
        {
            forceAmount = (forceAmount * megaBoostAmount)*(Input.GetAxis(megaBoostName)+Input.GetAxis("MegaBoostOn"));
        }

		if (Input.GetAxis ("BoostOn") > 0 || Input.GetAxis(boosterName) > 0) {
            float inputAmount = Mathf.Clamp(Input.GetAxis(boosterName), 0f, 1f);
            float spaceInputAmount = Input.GetAxis ("BoostOn");
            Manager.say("Input amount is: " + Input.GetAxis(boosterName) + " clamped: " + inputAmount, "Eliot");
            body.AddForceAtPosition(transform.forward * -forceAmount * (inputAmount+spaceInputAmount), transform.position, ForceMode.Force);
			transform.GetChild (0).gameObject.SetActive (true);
            if (audio.isPlaying == false) { audio.Play(); } 
            audio.volume = (inputAmount+spaceInputAmount);
            transform.GetChild(0).transform.localScale = new Vector3(0.7f, 0.5f*(inputAmount+spaceInputAmount+(Mathf.Log(forceAmount)/20f - 1f)), .776f);
		} else {
			transform.GetChild (0).gameObject.SetActive (false);
            audio.Stop();
		}

        
		//rigidbody.AddRelativeForce (transform.forward);
	}
}
