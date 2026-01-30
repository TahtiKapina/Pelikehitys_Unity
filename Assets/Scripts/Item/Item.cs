using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Lis‰‰ esine inventoriin
            other.GetComponent<Inventory>().AddItem();

            // Poista esine
            Destroy(gameObject);
        }
    }
}
