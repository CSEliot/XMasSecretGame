using UnityEngine;
using System.Collections;

public class WaitForGifts : MonoBehaviour {

    public GameObject giftsText;
    private bool gottenAGift = false;
    private float finalTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider thing)
    {
        Manager.say("IN DELIVERY SPACE: " + thing.name, "Eliot");
        if (!gottenAGift) { finalTime = Time.timeSinceLevelLoad; gottenAGift = true; }
        if (thing.gameObject.layer == 10)
        {
            giftsText.GetComponent<GiftTextControl>().AddGiftCount();
        }
    }

    void OnTriggerExit(Collider thing)
    {
        Manager.say("OUT DELIVERY SPACE: " + thing.name, "Eliot");

        if (thing.gameObject.layer == 10)
        {
            giftsText.GetComponent<GiftTextControl>().SubtractGiftCount();
        }
    }
}
