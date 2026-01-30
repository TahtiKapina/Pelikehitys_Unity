using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField] private Guard areaGuard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            areaGuard.GetComponent<Guard>().ShowMessages("Pelaaja tuli alueelle!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            areaGuard.GetComponent<Guard>().ShowMessages("Pelaaja poistui alueelle!");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            areaGuard.GetComponent<Guard>().ShowMessages("Pelaaja on alueelle!");
        }
    }
}
