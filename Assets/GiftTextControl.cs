using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GiftTextControl : MonoBehaviour {

    private int giftCount = 0;
    private string GiftString;
    private Text presentsText;
	// Use this for initialization
	void Start () {
        GiftString = "Presents delivered to Unity-Chan: ";
        presentsText = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        presentsText.text = (GiftString + giftCount);
	}


    public void AddGiftCount()
    {
        giftCount++;
    }

    public void SubtractGiftCount()
    {
        giftCount--;
    }
}
