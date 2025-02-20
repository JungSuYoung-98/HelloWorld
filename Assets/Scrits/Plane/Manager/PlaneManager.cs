using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneManager : MonoBehaviour
{
    static PlaneManager planeManager;
    PlaneUIManager uiManager;
    GameManager gameManager;

    public static PlaneManager Instance
    {
        get { return planeManager; }
    }

    private int currentScore = 0;

    public PlaneUIManager UIManager
    {
        get { return uiManager; }
    }

    private void Awake()
    {
        planeManager = this;
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<PlaneUIManager>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
        
        if (gameManager.bestScore == 0)
        {
            return;
        }
        gameManager.bestScore = 0;
    }

    public void GameOver()
    {
        uiManager.SetRestart();

    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        BestScoreChk();
    }

    public void BestScoreChk()
    {
        gameManager.bestScore = currentScore > gameManager.bestScore ? currentScore : gameManager.bestScore;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitScene()
    {
        gameManager.satae = GameManager.Satae.Plane;
        SceneManager.LoadScene("PlaneExitScene");
    }

}