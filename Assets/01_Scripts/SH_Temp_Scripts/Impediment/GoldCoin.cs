using UnityEngine;

public class GoldCoin : Impediment, IInteract
{
    private float scoreValue = 100000;
    private string objectBTag = "Impediment";
    private float overlapThreshold = 3f;

    private void OnEnable()
    {
        distanceMoved = 0f;
        impedimentMoveSpeed = GameManager.Instance.objectSpeed;
    }

    private void Update()
    {
        CheckPositions();
        float moveDistance = impedimentMoveSpeed * Time.deltaTime;
        transform.Translate(0, moveDistance, 0);

        distanceMoved += moveDistance;
        if (distanceMoved >= targetDistance)
        {
            gameObject.SetActive(false);
        }
    }

    private void CheckPositions()
    {
        GameObject[] objectBs = GameObject.FindGameObjectsWithTag(objectBTag);

        foreach (GameObject objectB in objectBs)
        {
            // ObjectA와 ObjectB의 위치 거리 계산
            float distance = Vector3.Distance(transform.position, objectB.transform.position);

            // 거리 기준 내에 위치하면 ObjectB를 비활성화
            if (distance < overlapThreshold)
            {
                gameObject.SetActive(false);
            }
        }
    }
    public override void OnInteraction(GameObject ob)
    {
        if (ob.TryGetComponent<PlayerScript>(out var player))
        {
            Score score = player.GetComponent<Score>();
            score.AddScore(scoreValue);
            gameObject.SetActive(false);
        }
    }
}