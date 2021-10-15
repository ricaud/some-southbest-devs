using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearMessage : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(true);
    }

    // Update is called once per frame
	void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
            // StartCoroutine("WaitForSec");
        }
	}
}
