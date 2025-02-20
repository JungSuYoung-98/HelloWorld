using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaneUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI RestartText;

    public void Start()
    {
        RestartText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        RestartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}