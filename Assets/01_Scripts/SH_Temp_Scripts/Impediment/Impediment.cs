using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteract
{
    public void OnInteraction(GameObject ob);
}

public class Impediment : MonoBehaviour, IInteract
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

    public void OnInteraction(GameObject ob)
    {
        if(ob.TryGetComponent<PlayerScript>(out var player))
        {
            // player.xx 장애물에 부딪혔을 때 체력 감소 & 속도 감소 / 아이템 추가된다면 조건문 추가
            player.hpCondition.DecreaseHP();
            GameManager.Instance.DecreaseDifficulty();

            gameObject.SetActive(false);
        }
    }
}
