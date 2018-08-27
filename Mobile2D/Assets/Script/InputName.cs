using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour {
    public InputField inName;
    public Button btnNext,btnShowName;
    string name;

    public Text tvShow ; 
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void  getInName()
    {
        name = inName.text;

        
    }

    public void btnShow()
    {
        tvShow.text = inName.text+""; 
    }

    public void btnNextscene()
    {
        SceneManager.LoadScene("Ui2DTraveler");
    }
}
