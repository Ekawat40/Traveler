using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Color : MonoBehaviour {


    public GameObject panel;

    public SpriteRenderer head;



    public Color red;
    public Color yellow;
    public Color blue;

    public Button btn1;
    public Button btn2;
    public Button btn3;

    public int whatColor = 1;



    // Use this for initialization
    void Start()
    {
        panel.SetActive(false);

   

    }

    public void btn_1()
    {
        head.color = new UnityEngine.Color(1,0,0,1);
    }

    public void btn_2()
    {
        head.color = new UnityEngine.Color(0,0,1,1);
    }

    public void btn_3()
    {
        head.color = new UnityEngine.Color(0, 1, 1, 1);
    }

    // Update is called once per frame
    void Update () {

        if(whatColor == 1)
        {
            head.color = red;
        }else if(whatColor == 2)
        {
            head.color = yellow;
        }else if (whatColor == 3)
        {
            head.color = blue;
        }

    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }


    public void ClosePanel()
    {
        panel.SetActive(false);


    }


    public static implicit operator UnityEngine.Color(Color v)
    {
        throw new NotImplementedException();
    }
}
