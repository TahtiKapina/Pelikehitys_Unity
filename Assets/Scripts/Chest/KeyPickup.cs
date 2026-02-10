using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private int keyId = 1; // kulta = 1, hopea = 2

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (PlayerInventory.Instance == null)
        {
            Debug.LogWarning("PlayerInventory-singletonia ei löytynyt.");
            return;
        }

        if (PlayerInventory.Instance.AddKey(keyId))
        {
            Debug.Log("Avain poimittu maasta");
            Destroy(gameObject);
        }
    }
}
