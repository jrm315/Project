using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adoptButton : MonoBehaviour {

    public Button button;

    // Use this for initialization
    void Start () {
        button = GetComponent<Button>();
        button.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void turnOn()
    {
        
        button.gameObject.SetActive(true);
    }
}
