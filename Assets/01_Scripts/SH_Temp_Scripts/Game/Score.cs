using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float currentScore;
    // �ְ� ���� �ִ´ٸ� ���⿡

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

        // �⺻ ������ ���� ������ �ݿ�
        int baseScore = Mathf.RoundToInt(respawnFactor * speedFactor);

        // ���� ������ baseScore�� currentScore�� ��
        float score = baseScore + currentScore;

        // ���� ������ ������Ʈ
        currentScore = score;

        Debug.Log(score);
        return score;
    }
}
