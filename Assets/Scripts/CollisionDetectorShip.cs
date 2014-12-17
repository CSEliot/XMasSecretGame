using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionDetectorShip : MonoBehaviour {

    public AudioClip tapSound;
    string finalTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision floor)
    {
        if (floor.gameObject.name != "Christmas Gift")
        {
            audio.PlayOneShot(tapSound);
        }
        if (floor.gameObject.name == "Platform Finish")
        {
            finalTime = GameObject.Find("Canvas").GetComponentInChildren<IncreaseTimeCount>().Stop();
            Manager.say("Name touching ship is: " + floor.gameObject.name, "Eliot");
        }
    }
}
