using UnityEngine;
using System.Collections;

public class TurnControl : MonoBehaviour {

	float turnAmountX = 0f;
	float turnAmountZ = 0f;
    string turnStringX = "Horizontal";
    string turnStringZ = "Vertical";


	// Use this for initialization
	void Start () {
        if (GameObject.Find("GameMaster") != null && GameObject.Find("GameMaster").GetComponent<Master>().getPNum() == 2)
        {
            Manager.say("2P selected, constructiing Makeforce", "Eliot");
            if (gameObject.name == "Turner1")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner2")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner3")
            {
                turnStringX = turnStringX + "2";
                turnStringZ = turnStringZ + "2";
            }
            else if (gameObject.name == "Turner4")
            {
                turnStringX = turnStringX + "2";
                turnStringZ = turnStringZ + "2";
            }
        }
        else if (GameObject.Find("GameMaster") != null && GameObject.Find("GameMaster").GetComponent<Master>().getPNum() == 4)
        {
            Manager.say("4P selected, constructiing Makeforce", "Eliot");
            if (gameObject.name == "Turner1")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner2")
            {
                turnStringX = turnStringX + "2";
                turnStringZ = turnStringZ + "2";
            }
            else if (gameObject.name == "Turner3")
            {
                turnStringX = turnStringX + "3";
                turnStringZ = turnStringZ + "3";
            }
            else if (gameObject.name == "Turner4")
            {
                turnStringX = turnStringX + "4";
                turnStringZ = turnStringZ + "4";
            }
        }
        else
        {
            Manager.say("1P selected, constructiing Makeforce", "Eliot");
            if (gameObject.name == "Turner1")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner2")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner3")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
            else if (gameObject.name == "Turner4")
            {
                turnStringX = turnStringX + "1";
                turnStringZ = turnStringZ + "1";
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		turnAmountX = Input.GetAxis (turnStringX);
		turnAmountZ = Input.GetAxis (turnStringZ);
		transform.localEulerAngles = new Vector3 (90f * (turnAmountZ+Input.GetAxis("Vertical")), 0, 90f * -1f*(turnAmountX+Input.GetAxis("Horizontal"))); 
	}
}
