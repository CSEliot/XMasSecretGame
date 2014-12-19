using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GiftTextControl : MonoBehaviour {

    private int giftCount = 0;
    private string GiftString;
    private Text presentsText;
    private int bonus = 100;
    private float oldTime;
    private int totalGifts;


    private bool gottenAGift = false;
    private float finalTime = 0f;
	// Use this for initialization
	void Start () {
        GiftString = "Presents delivered to Unity-Chan: ";
        presentsText = gameObject.GetComponent<Text>();
        oldTime = Time.timeSinceLevelLoad;
        totalGifts = GameObject.FindGameObjectsWithTag("Gift").Length;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad - oldTime > 1 && finalTime==0f) { bonus--; oldTime = Time.timeSinceLevelLoad; }
        presentsText.text = (GiftString + giftCount + "/"+totalGifts) + "\nBonus: " + bonus;
        if (giftCount >= totalGifts)
        {
            GameObject.Find("unitychan").GetComponent<Animator>().SetBool("PresentsDelivered", true);
        }
	}


    public void AddGiftCount()
    {
        if (!gottenAGift) { finalTime = Time.timeSinceLevelLoad; gottenAGift = true;}
        giftCount++;
    }

    public void SubtractGiftCount()
    {
        giftCount--;
    }

    public int getHighScore()
    {
        return bonus * giftCount * 100;
    }
}
