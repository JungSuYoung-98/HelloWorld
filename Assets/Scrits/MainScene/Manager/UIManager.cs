using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI PlaneScore;
    public TextMeshProUGUI GameScore;
    public TextMeshProUGUI ResultText;
    GameManager GameManager;

    private void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        UpdateScore();
    }

    public void UpdateScore()
    {
        if (GameManager.satae == GameManager.Satae.Plane)
        {
            if (GameManager.bestScore > 4)
            {
                ResultText.text = "Clear !!!";
                int score = GameManager.bestScore * 100; ;
                GameManager.score += score;
                GameScore.text = score.ToString();
            }
            else
            {
                ResultText.text = "Fail ... ";
                GameScore.text = "0";
            }
            PlaneScore.text = GameManager.bestScore.ToString();
        }
        else
            GameScore.text = GameManager.score.ToString();
    }

}
