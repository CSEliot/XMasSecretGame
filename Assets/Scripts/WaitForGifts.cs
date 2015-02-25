using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaitForGifts : MonoBehaviour {

    public GameObject giftsText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider thing)
    {
        if (thing.gameObject.layer == 10)
        {
            Manager.say("IN DELIVERY SPACE: " + thing.name, "Eliot");
            GameObject.Find("FINAL SCORE").GetComponent<Text>().enabled = true;
            GameObject.Find("NextLevel").transform.GetChild(0).gameObject.SetActive(true);
            giftsText.GetComponent<GiftTextControl>().AddGiftCount();
        }
    }

    void OnTriggerExit(Collider thing)
    {
        if (thing.gameObject.layer == 10)
        {
            Manager.say("OUT DELIVERY SPACE: " + thing.name, "Eliot");
            giftsText.GetComponent<GiftTextControl>().SubtractGiftCount();
        }
    }
}
