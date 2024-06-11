using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Condition hpCondition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IInteract>(out var interact))
        {
            interact.OnInteraction(this.gameObject);
        }
    }
}