using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public float buildingMoveSpeed; // 방해물 오브젝트와 속도를 맞추기 위해 GameManager.cs에서 public 변수 선언하여 값 가져오기
    private float distanceMoved = 0f;
    private float targetDistance = 70f;

    private void OnEnable()
    {
        distanceMoved = 0f;
        buildingMoveSpeed = GameManager.Instance.objectSpeed;
    }

    private void Update()
    {
        float moveDistance = buildingMoveSpeed * Time.deltaTime;
        transform.Translate(moveDistance, 0, 0);

        distanceMoved += moveDistance;
        if(distanceMoved >= targetDistance)
        {
            gameObject.SetActive(false);
        }
    }
}
