﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour {

    AsyncOperation operaçao;

    public Slider barraDeLoading;

    // Use this for initialization
    void Start () {

        StartCoroutine("LevelLoad");
        
    }

    IEnumerator LevelLoad()
    {
        operaçao = SceneManager.LoadSceneAsync(Persistence.NextLevel);

        while (!operaçao.isDone)
        {
            float processo = Mathf.Clamp01(operaçao.progress / .9f);
            barraDeLoading.value = processo;
            yield return null;
        }
    }
}
