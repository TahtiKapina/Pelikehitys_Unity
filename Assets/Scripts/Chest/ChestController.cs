using UnityEngine;
using UnityEngine.InputSystem;

public class ChestController : MonoBehaviour
{
    [SerializeField] private int requiredKeyId = 1;
    [SerializeField] private Animator chestAnimator;

    private bool isOpen = false;

    public void Open()
    {
        isOpen = true;
        chestAnimator.SetTrigger("Open");
        Debug.Log("Arkku avattu");
    }

    public void TryOpen(PlayerInventory inventory)
    {
        if (isOpen) return;

        if (inventory != null && inventory.HasKey(requiredKeyId))
        {
            Open();
            inventory.ClearKey();
        }
        else
        {
            Debug.Log("V‰‰r‰ avain tai avainta ei ole");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            TryOpen(inventory);
        }
    }
}
