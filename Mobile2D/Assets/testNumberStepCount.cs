using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testNumberStepCount : MonoBehaviour {
    int moneyAmount;
    int stepCount;

    public Text tvSuccess;
    public Button btnAddStep;
    public Text tvStepCount;
    public Text tvMoney;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        btnAddStep.interactable = true;

    }

    public void btnAdd()
    {

        stepCount += 1000;

        moneyAmount += 1000;
        tvSuccess.text = "Sold!";
        btnAddStep.gameObject.SetActive(false);
    }
    }
