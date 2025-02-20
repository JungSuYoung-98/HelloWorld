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
    private void OnCollisionEnter2D() // 오브젝트 접촉시
    {
        SceneManager.LoadScene("PlaneStartScene");
    }

    public void PlaneStartButton() // 게임 시작 버튼
    {
        SceneManager.LoadScene("PlaneScene");
        
    }

    public void PlaneExitButton() // 게임 나가기 버튼
    {
        gameManager.satae = GameManager.Satae.Main;
        SceneManager.LoadScene("MainScene");
    }

}
