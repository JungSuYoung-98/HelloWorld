using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Satae // �� ����
    {
        Main,
        Plane
    }

    public static GameManager instance = null;

    public Satae satae = Satae.Main;
    public int score = 0;
    public int bestScore = 0;
    public int Score { get => score; }
    private const string ScoreKey = "Score";


    private void Awake()
    {

        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }
    }

    private void Start()
    {
        score = PlayerPrefs.GetInt(ScoreKey, 0); // ���� �ҷ�����
    }

    private void Update()
    {
        PlayerPrefs.SetInt(ScoreKey, score); // ���� ����
    }
}
   