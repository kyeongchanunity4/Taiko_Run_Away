using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public float buildingMoveSpeed; // ���ع� ������Ʈ�� �ӵ��� ���߱� ���� GameManager.cs���� public ���� �����Ͽ� �� ��������
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
