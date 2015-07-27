using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionDetectorChanHead : MonoBehaviour {

    public AudioClip shipHitSound;
    public AudioClip breakSound;
    public AudioClip giftHitSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision floor)
    {
        if (floor.gameObject.layer != 8 && floor.gameObject.layer == 9)
        {   
            //ship contact noise!
            if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > 1 || floor.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 1)
            {
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    if (gameObject.name == "Character1_Neck") { GetComponent<AudioSource>().PlayOneShot(breakSound); }
                    GetComponent<AudioSource>().PlayOneShot(shipHitSound);
                }

            }
        }
        if (floor.gameObject.layer == 10)
        {
            //gift contact noise!
            if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > 1 || floor.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 1)
            {
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    if (gameObject.name == "Character1_Neck") { GetComponent<AudioSource>().PlayOneShot(breakSound); }
                    GetComponent<AudioSource>().PlayOneShot(giftHitSound);
                }
            }
        }

        
    }
}
