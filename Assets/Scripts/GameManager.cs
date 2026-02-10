using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("Duplicate GameManager instance found and destroyed.");

            return;
        }

        else
        {
            Debug.Log("GameManager instance created.");
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }  
}
