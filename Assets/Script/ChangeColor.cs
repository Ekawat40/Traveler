using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {
    public SpriteRenderer skin;
    public Color[] colors;
    public Image skinDisplay;
    public int whatColor;
    public GameObject Panel;

    void Start()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        skinDisplay.color = skin.color;
        for (int i = 0; i < colors.Length; i++)
        {
            if (i == whatColor)
            {
                skin.color = colors[i];
            }
        }
           
    }

    public void ChangePanelState(bool state)
    {
        Panel.SetActive(state);
    }

    public void ChangeSkinColor(int index)
    {
        whatColor = index;
    }
}
