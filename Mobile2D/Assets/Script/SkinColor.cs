using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinColor : MonoBehaviour
{

    public SpriteRenderer head;
    public SpriteRenderer hand_1;
    public SpriteRenderer hand_2;
    public SpriteRenderer leg_1;
    public SpriteRenderer leg_2;


    public Button btn1;
    public Button btn2;
    public Button btn3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void btn_1()
    {
        head.color = new UnityEngine.Color(1, 0, 0, 1);
        hand_1.color = new UnityEngine.Color(1, 0, 0, 1);
        hand_2.color = new UnityEngine.Color(1, 0, 0, 1);
        leg_1.color = new UnityEngine.Color(1, 0, 0, 1);
        leg_2.color = new UnityEngine.Color(1, 0, 0, 1);

    }

    public void btn_2()
    {
        head.color = new UnityEngine.Color(0, 0, 1, 1);
        hand_1.color = new UnityEngine.Color(0, 0, 1, 1);
        hand_2.color = new UnityEngine.Color(0, 0, 1, 1);
        leg_1.color = new UnityEngine.Color(0, 0, 1, 1);
        leg_2.color = new UnityEngine.Color(0, 0, 1, 1);

    }

    public void btn_3()
    {
        head.color = new UnityEngine.Color(1, 1, 0, 1);
        hand_1.color = new UnityEngine.Color(1, 1, 0, 1);
        hand_2.color = new UnityEngine.Color(1, 1, 0, 1);
        leg_1.color = new UnityEngine.Color(1, 1, 0, 1);
        leg_2.color = new UnityEngine.Color(1, 1, 0, 1);

    }
}
