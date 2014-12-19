using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MakeForce : MonoBehaviour {

	float rotateZ;
	public Rigidbody body;
    //public AudioClip boostNoise;
	public float forceAmount;
    private float newForceAmount;
    public float megaBoostAmount;
    private string boosterName;
    private string megaBoostName;
    public Material megaBoostMat;
    public Material normalBoostMat;
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
        newForceAmount = forceAmount;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetAxis(megaBoostName) > 0 || Input.GetAxis("MegaBoostOn") > 0)
        {
            newForceAmount = (forceAmount * megaBoostAmount)*(Input.GetAxis(megaBoostName)+Input.GetAxis("MegaBoostOn"));
            transform.GetChild(0).GetComponent<MeshRenderer>().material = megaBoostMat;
            transform.GetChild(0).GetChild(0).GetComponent<Light>().color = Color.cyan;
            transform.GetChild(0).GetChild(0).GetComponent<Light>().intensity = 1.5f;
        }
        else
        {
            newForceAmount = forceAmount;
            transform.GetChild(0).GetComponent<MeshRenderer>().material = normalBoostMat;
            transform.GetChild(0).GetChild(0).GetComponent<Light>().color = Color.yellow;
        }

		if (Input.GetAxis ("BoostOn") > 0 || Input.GetAxis(boosterName) > 0) {
            float inputAmount = Mathf.Clamp(Input.GetAxis(boosterName), 0f, 1f);
            transform.GetChild(0).GetChild(0).GetComponent<Light>().intensity = 3.5f*(inputAmount+Input.GetAxis ("BoostOn"));
            float spaceInputAmount = Input.GetAxis ("BoostOn");
            Manager.say("Input amount is: " + Input.GetAxis(boosterName) + " clamped: " + inputAmount, "Eliot");
            body.AddForceAtPosition(transform.forward * -newForceAmount * (inputAmount+spaceInputAmount), transform.position, ForceMode.Force);
			transform.GetChild (0).gameObject.SetActive (true);
            if (audio.isPlaying == false) { audio.Play(); } 
            audio.volume = (inputAmount+spaceInputAmount);
            Manager.say("Math equation is: " +(Mathf.Log(newForceAmount*newForceAmount*newForceAmount) / 20f -0.8f), "Eliot2");
            transform.GetChild(0).transform.localScale = new Vector3(0.7f, 0.5f * (inputAmount + spaceInputAmount + (Mathf.Log(newForceAmount * newForceAmount * newForceAmount) / 20f - 0.8f)), .776f);

		} else {
			transform.GetChild (0).gameObject.SetActive (false);
            audio.Stop();
		}

        
		//rigidbody.AddRelativeForce (transform.forward);
	}
}
