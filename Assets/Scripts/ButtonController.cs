using UnityEngine;

/// <summary>
/// Luokka on vuorovaikutuksessa painikkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenChest();
        }
    }

    // TEHTÄVÄ:
    // 1. Tee metodi, jota voidaan kutsua E-painikkeet painalluksesta

    public void OpenChest()
    {
        if (chest != null)
        {
            chest.OpenChest();
        }
        else
        {
            Debug.LogWarning("Chest reference is missing!");
        }
    }
}
