using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        if(DialogueManger.count < 3)
        {
            DialogueManger.count = DialogueManger.count + 1;
        }
        if(DialogueManger.count == 3)
        {
            DialogueManger.count = 0;
        }
    }
}
