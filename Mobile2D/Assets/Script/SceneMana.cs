﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMana : MonoBehaviour {

    public void SceneTransition()
    {
        SceneManager.LoadScene("RandomCountry");
    }
}
