using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomCountry : MonoBehaviour {


    /*Random random = new Random();
   int randomNumber = Random.Range(1,3);*/
    int randomNumber = 1;
    public int stepCountry;
    public int num=0;
    public int num1=0;
    public int stepCount;
    public Button btnAddStep;
    public Text tvStepCount;
    public Text tvShowRnd;



    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

        SetCountry();


    }



    public void SetCountry()
    {
        if (randomNumber == 1)
        {
            stepCountry = 4000;
        }
        else if (randomNumber == 2)
        {
            stepCountry = 4500;
        }
        else if (randomNumber == 3)
        {
            stepCountry = 5000;
        }
        else
        {
            CountryLink();
        }

        if (num >= stepCountry)
        {
            CountryLink();
        }

    }

    public void CountryLink()
    {

        stepCountry = 4700;
        if (num >= stepCountry)
        {
            randomNumber = Random.Range(1, 3);
        }
    }

    public void btnAdd()
    {

        num1 += 1000;
        num = num1;

        tvStepCount.text = num + "" ;

        tvShowRnd.text = randomNumber + "" ;

    }


    }
