using System;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Luokka on vuorovaikutuksessa paini  kkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Debug.Log("E was pressed");

            OpenChest();
        }
    }

    // TEHTÄVÄ:
    // 1. Tee metodi, jota voidaan kutsua E-painikkeet painalluksesta

    public void OpenChest()
    {
        if (chest != null)
        {
            chest.Open();

            Debug.Log("Arkku on Auki");
        }
        else
        {
            Debug.LogWarning("Chest reference is missing!");
        }
    }
}
