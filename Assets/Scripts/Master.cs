using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {

    private int PNum;
    private int totalHighScore = 0;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}

    void OnEnable()
    {
        Debug.Log("I have started!");
        DontDestroyOnLoad(transform.gameObject);
    }

	// Update is called once per frame
	void Update () {/*
        if (Input.GetButtonDown("Submit"))
        {
            if (GameObject.Find("Scoretext") != null)
            {
                if (GameObject.Find("Scoretext").gameObject.GetComponent<GiftTextControl>().getHighScore() > 0f)
                {
                    if (GameObject.Find("GameMaster") != null)
                    {
                        int addScore = GameObject.Find("FINAL SCORE").GetComponent<getFinalScore>().getHighScore();
                        GameObject.Find("GameMaster").GetComponent<Master>().addToHighScore(addScore);
                    }
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }
        }*/
        if (Input.GetButtonDown("Restart"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetButtonDown("NextLevel"))
        {
            Application.LoadLevel(Application.loadedLevel+1);
        }

        if (Input.GetButtonDown("Quit"))
        {
            Manager.say("Quitting!", "Eliot");
            Application.Quit();
        }
	}

    public void setPNum(int givenPNum)
    {
        PNum = givenPNum;
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public int getPNum()
    {
        return PNum;
    }

    public void addToHighScore(int pointsToAdd)
    {
        totalHighScore += pointsToAdd;
    }

    public int totalScoreSoFar()
    {
        return totalHighScore;
    }
}
