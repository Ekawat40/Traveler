using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StepAdd : MonoBehaviour
{
    private InputName input;

    int moneyAmount;
    int stepCount;


    public Text tvOI;
    public Text tvSuccess;
    public Button btnAddStep;
    public Text tvStepCount;
    public Text tvMoney;

    public Text tvName; 
    int num, mon;

    public Text tvAcc;
    int numAcc;

    public float bgSpeed;
    float bgPositionX;
    float bgPositionX1;

    public GameObject dishes1, dishes2, dishes3, dishes4;




       
    




    Vector3 accelerationDir ;

    // Use this for initialization
    void Start()
    {
        bgPositionX = transform.position.x;

        bgPositionX1 = GameObject.Find("Background").transform.position.x;

      
    }

    // Update is called once per frame
    void Update()
    {


        accelerationDir = Input.acceleration;

        if (accelerationDir.sqrMagnitude >= 5f)
        {
            numAcc += 1;
        }

        tvAcc.text = numAcc + "";

 
        if (num>=4700)
        {
            
            tvOI.text = "BG_1";
        }

        transform.position = new Vector3(transform.position.x + bgSpeed, transform.position.y, transform.position.z);
        if (transform.position.x < (bgPositionX1 * -1.25f))
        {
            transform.position = new Vector3(bgPositionX1, transform.position.y, transform.position.z);
        }

    }

    public void btnAdd()
    {

        stepCount += 1000;
        num = stepCount;
        moneyAmount += 1000;
        mon = moneyAmount;
        tvStepCount.text = num + "";
        tvMoney.text = mon + "";

    }


}
