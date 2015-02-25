using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getFinalScore : MonoBehaviour {

    public GameObject textController;
    private Text finalText;
    private string strText = "FINAL SCORE\n";
    private int highscore;
	// Use this for initialization
	void Start () {
        finalText = gameObject.GetComponent<Text>();
        finalText.text = strText;
	}
	
	// Update is called once per frame
	void Update () {
        highscore = textController.GetComponent<GiftTextControl>().getHighScore();
        Manager.say("Highschore: " + highscore, "Eliot2");
        int totalHighScore = GameObject.Find("GameMaster") != null ? GameObject.Find("GameMaster").GetComponent<Master>().totalScoreSoFar() : 0;
        finalText.text = strText + highscore + "\n TOTAL IS: " + (totalHighScore+highscore);
	}

    public int getHighScore()
    {
        return highscore;
    }
}
