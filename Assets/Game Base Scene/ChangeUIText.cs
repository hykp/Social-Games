﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeUIText : MonoBehaviour {

    public string baseString;
    private GameObject player;
    private BaseAttributesAndCommands pcAttributes;

    Text thisText;
    
	// Use this for initialization
	void Start () {
        pcAttributes = GameObject.Find("Player").GetComponent<BaseAttributesAndCommands>();
        thisText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        grabAndUpdateFromPCAttributes();
	}

    void grabAndUpdateFromPCAttributes()
    {
        if (baseString == "Food & Water:")
        {
            thisText.text = baseString + " " + pcAttributes.getCurFood().ToString() + "/" + pcAttributes.getMaxFood().ToString();
        }
        if (baseString == "Supplies:")
        {
            thisText.text = baseString + " " + pcAttributes.getCurResources().ToString() + "/" + pcAttributes.getMaxResources().ToString();
        }

    }


}