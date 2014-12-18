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
        Manager.say("Going to the next level!", "Eliot");
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
