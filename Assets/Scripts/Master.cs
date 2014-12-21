using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {

    private bool is2P;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
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

    public void set2P(bool isIt2P)
    {
        is2P = isIt2P;
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public bool getIs2P()
    {
        return is2P;
    }
}
