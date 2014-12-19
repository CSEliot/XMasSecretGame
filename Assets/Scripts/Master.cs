using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Restart"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetButtonDown("Quit"))
        {
            Manager.say("Quitting!", "Eliot");
            Application.Quit();
        }
	}

    public void OnEnable()
    {
        if (GameObject.Find("Scoretext").gameObject.GetComponent<GiftTextControl>().getHighScore() > 0f)
        {
            Manager.say("Going to the next level!", "Eliot");
            if (Input.GetButtonDown("Submit"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

        }
    }
}
