using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnEnable()
    {
        if (GameObject.Find("Scoretext") != null)
        {
            if (GameObject.Find("Scoretext").gameObject.GetComponent<GiftTextControl>().getHighScore() > 0f)
            {
                    Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
    }
}
