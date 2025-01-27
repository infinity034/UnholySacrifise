using UnityEngine;

public class ContactZone : MonoBehaviour
{
    [SerializeField]
    private Transform playerForestTeleportPoint, priestForestTeleportPoint;
    [SerializeField]
    private NPC priest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GetComponentInParent<NPC>().Zone.PlayerSeen)
            {
                TeleportPlayerAndPriestToForest();
            }
        }
        else if (collision.gameObject.CompareTag("Door"))
        {

        }
    }

    public void TeleportPlayerAndPriestToForest()
    {
        Debug.Log("Teleport");
        Player.Instance.transform.position = playerForestTeleportPoint.position;
        ImpactBar.Instance.ResetToZero();
        if (priestForestTeleportPoint && priest)
        {
            priest.Body.position = priestForestTeleportPoint.position;
        }
        if (Library.Instance.Open)
        {
            Library.Instance.Use();
        }
    }
}
