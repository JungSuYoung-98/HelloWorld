using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenechangeManager : MonoBehaviour
{
    UIManager uIManager;
    GameManager gameManager;

    private void Awake()
    {
        uIManager = GetComponent<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D()
    {
        SceneManager.LoadScene("PlaneStartScene");
    }

    public void PlaneStartButton()
    {
        SceneManager.LoadScene("PlaneScene");
        
    }

    public void PlaneExitButton()
    {
        gameManager.satae = GameManager.Satae.Main;
        SceneManager.LoadScene("MainScene");
    }

}
