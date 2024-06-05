using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteract
{
    public void OnInteraction(GameObject ob);
}

public class Impediment : MonoBehaviour, IInteract
{
    public float impedimentMoveSpeed;// �ǹ� ������Ʈ�� �ӵ��� ���߱� ���� GameManager.cs���� public ���� �����Ͽ� �� ��������
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
            // player.xx ��ֹ��� �ε����� �� ü�� ���� & �ӵ� ���� / ������ �߰��ȴٸ� ���ǹ� �߰�
            player.hpCondition.DecreaseHP();
            GameManager.Instance.DecreaseDifficulty();

            gameObject.SetActive(false);
        }
    }
}
