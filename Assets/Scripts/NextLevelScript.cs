using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToNextLevel()
    {
        if (GameObject.Find("Scoretext") != null)
        {
            if (GameObject.Find("Scoretext").gameObject.GetComponent<GiftTextControl>().getHighScore() > 0f)
            {
                    if(GameObject.Find("GameMaster") != null){
                        int addScore = GameObject.Find("FINAL SCORE").GetComponent<getFinalScore>().getHighScore();
                        GameObject.Find("GameMaster").GetComponent<Master>().addToHighScore(addScore);
                    }
                    Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
    }
}
