using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptLinearTimmer : MonoBehaviour {

    public Button btntest;
    Image timerBar;
    public float maxTime = 4700f;
    float timeleft;

	// Use this for initialization
	void Start () {

        timerBar = GetComponent<Image>();
        timeleft = maxTime;

        timerBar.fillAmount = 0;

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    public void btn()
    {

        timerBar.fillAmount += 0.01f;

     
    }



}
