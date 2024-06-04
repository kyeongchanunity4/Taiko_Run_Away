using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float currentScore;
    // 최고 점수 넣는다면 여기에

    private void Update()
    {
        currentScore = CalculateScore();
        scoreText.text = currentScore.ToString("N0");
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

        Debug.Log(score);
        return score;
    }
}
