using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_random : MonoBehaviour {

    Random random = new Random();
    /*int randomNumber = Random.Range(1, 3);*/
    int randomNumber = 1;
    int stepCountry;
    int num;
    int stepCount;
    public Button btnAddStep;
    public Text tvStepCount;
    public Text tvShowRndCountry;



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        btnAddStep.interactable = true;

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

        stepCount += 1000;
        num = stepCount;

    }


}
