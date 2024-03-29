﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionDetectorGiftBox : MonoBehaviour {

    public AudioClip tapSound;
    public AudioClip breakSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision floor)
    {
        if (floor.gameObject.name == "floor" || floor.gameObject.name == "Platform Start")
        {
            GetComponent<AudioSource>().PlayOneShot(breakSound);
            GameObject.Find("unitychan").GetComponent<Animator>().SetBool("HasFailed", true);
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(tapSound);
        }

        if (floor.gameObject.layer == 8 && GetComponent<Rigidbody>().velocity.magnitude > 1)
        {
            GameObject.Find("unitychan").gameObject.GetComponent<Animator>().enabled = false;
            GameObject.Find("unitychan").gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
