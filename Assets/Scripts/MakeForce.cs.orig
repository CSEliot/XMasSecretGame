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
    private string boostON = "BoostOn";
    private string megaBoostName;
    public Material megaBoostMat;
    public Material normalBoostMat;



	// Use this for initialization
	void Start () {
        if (GameObject.Find("GameMaster") != null && GameObject.Find("GameMaster").GetComponent<Master>().getPNum() == 2)
        {
            Manager.say("2P selected, constructiing Makeforce", "Eliot");
            if (gameObject.name == "Rocket1")
            {
                boosterName = "Booster1";
                megaBoostName = "MegaBoost1";
            }
            else if (gameObject.name == "Rocket2")
            {
                boosterName = "Booster1";
                megaBoostName = "MegaBoost1";
            }
            else if (gameObject.name == "Rocket3")
            {
                boosterName = "Booster2";
                megaBoostName = "MegaBoost2";
            }
            else if (gameObject.name == "Rocket4")
            {
                boosterName = "Booster2";
                megaBoostName = "MegaBoost2";
            }
        }
        else if (GameObject.Find("GameMaster") != null && GameObject.Find("GameMaster").GetComponent<Master>().getPNum() == 4)
        {
            Manager.say("4P selected, constructiing Makeforce", "Eliot");
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
        else
        {
            boostON = "BoostOnSP";
            Manager.say("1P selected, constructiing Makeforce", "Eliot");
            if (gameObject.name == "Rocket1")
            {
                boosterName = "Booster1";
                megaBoostName = "MegaBoost1";
            }
            else if (gameObject.name == "Rocket2")
            {
                boosterName = "Booster2";
                megaBoostName = "MegaBoost1";
            }
            else if (gameObject.name == "Rocket3")
            {
                boosterName = "Booster3";
                megaBoostName = "MegaBoost1";
            }
            else if (gameObject.name == "Rocket4")
            {
                boosterName = "Booster4";
                megaBoostName = "MegaBoost1";
            }
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

		if (Input.GetAxis (boostON) > 0) {
            Manager.say("Boosting by: " + boosterName, "Eliot");
            transform.GetChild(0).GetChild(0).GetComponent<Light>().intensity = 3.5f*(Input.GetAxis (boostON));
            float spaceInputAmount = Mathf.Clamp(Input.GetAxis(boostON), 0f, 1f);
            body.AddForceAtPosition(transform.forward * -newForceAmount * (spaceInputAmount), transform.position, ForceMode.Force);
			transform.GetChild (0).gameObject.SetActive (true);
            if (GetComponent<AudioSource>().isPlaying == false) { GetComponent<AudioSource>().Play(); } 
            GetComponent<AudioSource>().volume = (spaceInputAmount);
            Manager.say("Math equation is: " +(Mathf.Log(newForceAmount*newForceAmount*newForceAmount) / 20f -0.8f), "Eliot2");
            transform.GetChild(0).transform.localScale = new Vector3(0.7f, 0.5f * (spaceInputAmount + (Mathf.Log(newForceAmount * newForceAmount * newForceAmount) / 20f - 0.8f)), .776f);
        } else if (Input.GetAxis(boosterName) > 0){
            Manager.say("Boosting by: " + boosterName, "Eliot");
            float inputAmount = Mathf.Clamp(Input.GetAxis(boosterName), 0f, 1f);
            transform.GetChild(0).GetChild(0).GetComponent<Light>().intensity = 3.5f * (inputAmount);
            Manager.say("Input amount is: " + Input.GetAxis(boosterName) + " clamped: " + inputAmount, "Eliot");
            body.AddForceAtPosition(transform.forward * -newForceAmount * (inputAmount), transform.position, ForceMode.Force);
            transform.GetChild(0).gameObject.SetActive(true);
            if (GetComponent<AudioSource>().isPlaying == false) { GetComponent<AudioSource>().Play(); }
            GetComponent<AudioSource>().volume = (inputAmount);
            Manager.say("Math equation is: " + (Mathf.Log(newForceAmount * newForceAmount * newForceAmount) / 20f - 0.8f), "Eliot2");
            transform.GetChild(0).transform.localScale = new Vector3(0.7f, 0.5f * (inputAmount + (Mathf.Log(newForceAmount * newForceAmount * newForceAmount) / 20f - 0.8f)), .776f);

        }else {
			transform.GetChild (0).gameObject.SetActive (false);
            GetComponent<AudioSource>().Stop();
		}

        
		//rigidbody.AddRelativeForce (transform.forward);
	}
}
