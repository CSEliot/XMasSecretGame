using UnityEngine;
using System.Collections;

public class SwapCameras : MonoBehaviour {

    public float swapTime;
    bool isActive = true;
    float oldTime;
	// Use this for initialization
	void Start () {
        oldTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if ((Time.time - oldTime) > swapTime)
        {
            isActive = !isActive;
            oldTime = Time.time;
            Manager.say("Swap Cameras!" + (int)Time.time, "Eliot");
            transform.GetChild(1).gameObject.SetActive(isActive);
        }
	}
}
