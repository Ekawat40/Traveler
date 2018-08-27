using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBG : MonoBehaviour
{
    public GameObject BG1, BG2;
    // variable contains which avatar is on and active
    int whichAvatarIsOn = 1;


    public Text stepCount;
    public GameObject tvBox;

    int num , TheNumber;

    Vector3 accelerationDir;



    Image timerBar;
    public float maxTime = 0f;
    float timeleft;




    // Use this for initialization
    void Start()
    {

        timerBar = GetComponent<Image>();
        timeleft = maxTime;

        timerBar.fillAmount = 0;


        // anable first avatar and disable another one
        BG1.gameObject.SetActive(true);
        BG2.gameObject.SetActive(false);

        TheNumber = Random.Range(1, 3);
        if (TheNumber == 1)
        {
            maxTime = 500f;
            whichAvatarIsOn = 2;

            // disable the first one and anable the second one
            BG1.gameObject.SetActive(false);
            BG2.gameObject.SetActive(true);
        }
        else
        {
            maxTime = 1000f;
            whichAvatarIsOn = 1;

            // disable the second one and anable the first one
            BG1.gameObject.SetActive(true);
            BG2.gameObject.SetActive(false);
        }
    }

    void Update()
    {

        accelerationDir = Input.acceleration;

        if (accelerationDir.sqrMagnitude >= 5f)
        {
            num += 1;

            stepCount.text = num + "";

        }

        SwitchBG();
    }

    /*
        public void Rnd()
    {
        TheNumber = Random.Range(1,3);
        if(TheNumber == 1)
        {
            whichAvatarIsOn = 2;

            // disable the first one and anable the second one
            BG1.gameObject.SetActive(false);
            BG2.gameObject.SetActive(true);
        }
        else
        {
            whichAvatarIsOn = 1;

            // disable the second one and anable the first one
            BG1.gameObject.SetActive(true);
            BG2.gameObject.SetActive(false);
        }

        tvBox.GetComponent<Text>().text = "" + TheNumber;

      
    }*/

    // public method to switch avatars by pressing UI button
    public void SwitchBG()
    {




        if(num == 500)
        {
            // then the second avatar is on now
            whichAvatarIsOn = 2;

            // disable the first one and anable the second one
            BG1.gameObject.SetActive(false);
            BG2.gameObject.SetActive(true);
        }else if(num == 1000)
        {
            whichAvatarIsOn = 1;

            // disable the second one and anable the first one
            BG1.gameObject.SetActive(true);
            BG2.gameObject.SetActive(false);
        }
        /*
        // processing whichAvatarIsOn variable
        switch (whichAvatarIsOn)
        {

            // if the first avatar is on
            case 1:

                // then the second avatar is on now
                whichAvatarIsOn = 2;

                // disable the first one and anable the second one
                BG1.gameObject.SetActive(false);
                BG2.gameObject.SetActive(true);
                break;

            // if the second avatar is on
            case 2:

                // then the first avatar is on now
                whichAvatarIsOn = 1;

                // disable the second one and anable the first one
                BG1.gameObject.SetActive(true);
                BG2.gameObject.SetActive(false);
                break;*/
        
    }

}
