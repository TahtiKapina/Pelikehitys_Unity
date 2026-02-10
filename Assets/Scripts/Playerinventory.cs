using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance { get; private set; }

    [SerializeField] private int currentKeyId = -1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("Duplicate PlayerInventory instance found and destroyed.");
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("PlayerInventory instance created.");
    }

    public bool HasKey(int id)
    {
        return currentKeyId == id;
    }

    public bool AddKey(int id)
    {
        if (currentKeyId != -1)
        {
            Debug.Log("Pelaajalla on jo avain");
            return false;
        }

        currentKeyId = id;
        Debug.Log("Avain poimittu, avaimen ID: " + id);
        return true;
    }

    public void ClearKey()
    {
        currentKeyId = -1;
        Debug.Log("Avain poistettu inventaariosta");
    }
}
