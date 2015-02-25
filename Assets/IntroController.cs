using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class IntroController : MonoBehaviour {

    public float scrollSpeed;
    private RectTransform rectTrans;
    private float yPos = -900;
    private bool enabledThings = false;
    public float waitTime;
	// Use this for initialization
	void Start () {
        rectTrans = GameObject.Find("Canvas").transform.GetChild(1).GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        yPos += scrollSpeed;
        rectTrans.anchoredPosition = new Vector2(0, yPos);

        if (Time.timeSinceLevelLoad > waitTime && enabledThings == false)
        {
            GameObject.Find("AlsoNotImage").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true);
            GameObject.Find("IntroController").SetActive(false);
            enabledThings = true;
            Debug.Log("Enablged THings");
        }
    }
}
