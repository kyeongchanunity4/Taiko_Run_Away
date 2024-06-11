using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreText_EndPanel;
    [SerializeField] private TextMeshProUGUI bestScoreText_EndPanel;
    [SerializeField] private TextMeshProUGUI scoreText_PausePanel;

    private float currentScore;
    private float bestScore;

    private void Awake()
    {
        bestScore = PlayerPrefs.GetFloat("BestScore", 0.0f);
    }

    private void Update()
    {
        //currentScore = CalculateScore();
        scoreText.text = currentScore.ToString("N0");
        scoreText_PausePanel.text = currentScore.ToString("N0");
    }

    private float CalculateScore()
    {
        float curRespawn = GameManager.Instance.objectRespawn;
        float curSpeed = GameManager.Instance.objectSpeed;

        float respawnFactor = Mathf.Lerp(1.0f, 2.0f, (3.0f - curRespawn) / 1.5f);
        float speedFactor = Mathf.Lerp(1.0f, 2.0f, (curSpeed - 10.0f) / 10.0f);

        // �⺻ ������ ���� ������ �ݿ�
        int baseScore = Mathf.RoundToInt(respawnFactor * speedFactor);

        // ���� ������ baseScore�� currentScore�� ��
        float score = baseScore + currentScore;

        // ���� ������ ������Ʈ
        currentScore = score;

        return score;
    }

    public void AddScore(float value)
    {
        currentScore += value;
    }

    public void SetEndPanelScore()
    {
        scoreText_EndPanel.text = currentScore.ToString("N0");
        if (currentScore >= bestScore)
        {
            bestScoreText_EndPanel.text = currentScore.ToString("N0");
            bestScore = currentScore;
            PlayerPrefs.SetFloat("BestScore", bestScore);
        }
        else
        {
            bestScoreText_EndPanel.text = bestScore.ToString("N0");
        }
    }
}
