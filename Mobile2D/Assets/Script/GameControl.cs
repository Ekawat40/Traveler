using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour {

    int moneyAmount;
    int stepCount;

    public Text tvSuccess;
    public Button btnAddStep;
    public Text tvStepCount;
    public Text tvMoney;
    int num,mon;

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
        num = stepCount;
        moneyAmount += 1000;
        mon = moneyAmount;
        tvStepCount.text = num+"";
        tvMoney.text = mon+"";
        tvSuccess.text = "Add Success";
        btnAddStep.gameObject.SetActive(false);

    }

    /*public void buyLootbox()
    {
        moneyAmount -= 200;
        PlayerPrefs.SetInt("IsLootboxSold", 1);
        LootboxPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }



    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        LootboxPrice.text = "Price: 200$";
        PlayerPrefs.DeleteAll();
    }*/

}

