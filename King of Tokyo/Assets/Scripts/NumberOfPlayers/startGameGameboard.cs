﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;//For scene management function
using UnityEngine;

public class startGameGameboard : MonoBehaviour
{
    public void sceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
