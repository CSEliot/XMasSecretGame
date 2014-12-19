using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getFinalScore : MonoBehaviour {

    public GameObject textController;
    private Text finalText;
    private string strText = "FINAL SCORE\n";
    int highscore;
	// Use this for initialization
	void Start () {
        finalText = gameObject.GetComponent<Text>();
        finalText.text = strText;
	}
	
	// Update is called once per frame
	void Update () {
        highscore = textController.GetComponent<GiftTextControl>().getHighScore();
        Manager.say("Highschore: " + highscore, "Eliot");
        finalText.text = strText + highscore;
	}
}
