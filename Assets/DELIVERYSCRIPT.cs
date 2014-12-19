using UnityEngine;
using System.Collections;

public class DELIVERYSCRIPT : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > 1)
        {
            if (transform.GetChild(2).gameObject.activeSelf == false)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
        }
        if (Time.timeSinceLevelLoad > 1.5)
        {
            if (transform.GetChild(3).gameObject.activeSelf == false)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
        }
        if (Time.timeSinceLevelLoad > 2)
        {
            if (transform.GetChild(4).gameObject.activeSelf == false)
            {
                transform.GetChild(4).gameObject.SetActive(true);
            }
        }

        if (Time.timeSinceLevelLoad > 3.6)
        {
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(4).gameObject.SetActive(false);
        }
	}
}
