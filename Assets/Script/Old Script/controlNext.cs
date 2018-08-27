using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlNext : MonoBehaviour {
    public InputField textInput;
    public string text;
    public Text textS;
    public Button nextButton;
	// Use this for initialization
    public void click()
    {
        textS = textInput.textComponent;
        SceneManager.LoadScene("main2");
    }
	void Start () {
       
        nextButton.onClick.AddListener(click);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
