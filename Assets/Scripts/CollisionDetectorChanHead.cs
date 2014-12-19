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
            if (gameObject.rigidbody.velocity.magnitude > 1 || floor.gameObject.rigidbody.velocity.magnitude > 1)
            {
                if (!audio.isPlaying)
                {
                    if (gameObject.name == "Character1_Neck") { audio.PlayOneShot(breakSound); }
                    audio.PlayOneShot(shipHitSound);
                }

            }
        }
        if (floor.gameObject.layer == 10)
        {
            //gift contact noise!
            if (gameObject.rigidbody.velocity.magnitude > 1 || floor.gameObject.rigidbody.velocity.magnitude > 1)
            {
                if (!audio.isPlaying)
                {
                    if (gameObject.name == "Character1_Neck") { audio.PlayOneShot(breakSound); }
                    audio.PlayOneShot(giftHitSound);
                }
            }
        }

        
    }
}
