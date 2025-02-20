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
    private void OnCollisionEnter2D() // ������Ʈ ���˽�
    {
        SceneManager.LoadScene("PlaneStartScene");
    }

    public void PlaneStartButton() // ���� ���� ��ư
    {
        SceneManager.LoadScene("PlaneScene");
        
    }

    public void PlaneExitButton() // ���� ������ ��ư
    {
        gameManager.satae = GameManager.Satae.Main;
        SceneManager.LoadScene("MainScene");
    }

}
