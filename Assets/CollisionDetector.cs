using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionDetector : MonoBehaviour {

    public AudioClip crashSound;
    public AudioClip tapSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision floor)
    {
        if (floor.gameObject.name == "floor")
        {
            audio.PlayOneShot(crashSound);
        }
        else
        {
            audio.PlayOneShot(tapSound);
        }
    }
}
