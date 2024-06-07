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
    public float distanceMoved = 0f;
    public float targetDistance = 70f;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

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

    public virtual void OnInteraction(GameObject ob)
    {
        if(ob.TryGetComponent<PlayerScript>(out var player))
        {
            AudioManager.Instance.PlaySound(audioSource);
            player.hpCondition.DecreaseHP();
            GameManager.Instance.DecreaseDifficulty();

            gameObject.SetActive(false);
        }
    }
}
