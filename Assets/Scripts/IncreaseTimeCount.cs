using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IncreaseTimeCount : MonoBehaviour {

    private Text timerText;
    bool timeTimer = true;
    string ogText;
	// Use this for initialization
	void Start () {
        timerText = gameObject.GetComponent<Text>();
        ogText = timerText.text;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeTimer)
        {
            timerText.text = ogText + Time.timeSinceLevelLoad.ToString();
        }
    }

    public string Stop()
    {
        timeTimer = false;
        return timerText.text;
    }
}
