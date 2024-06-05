using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impediment : MonoBehaviour
{
    public float impedimentMoveSpeed;// 건물 오브젝트와 속도를 맞추기 위해 GameManager.cs에서 public 변수 선언하여 값 가져오기
    private float distanceMoved = 0f;
    private float targetDistance = 70f;

    private void OnEnable()
    {
        distanceMoved = 0f;
        impedimentMoveSpeed = GameManager.Instance.objectSpeed;
    }

    private void Update()
    {
        float moveDistance = impedimentMoveSpeed * Time.deltaTime;
        transform.Translate(moveDistance, 0, 0);

        distanceMoved += moveDistance;
        if (distanceMoved >= targetDistance)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // 플레이어의 체력이 깎이는 함수
            gameObject.SetActive(false);
        }
    }
}
