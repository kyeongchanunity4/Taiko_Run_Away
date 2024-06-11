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

        // 기본 점수에 현재 점수를 반영
        int baseScore = Mathf.RoundToInt(respawnFactor * speedFactor);

        // 최종 점수는 baseScore와 currentScore의 합
        float score = baseScore + currentScore;

        // 현재 점수를 업데이트
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
