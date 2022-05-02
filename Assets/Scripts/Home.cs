using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject frogHome;

    private void OnEnable()
    {
        frogHome.SetActive(true);
    }

    private void OnDisable()
    {
        frogHome.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enabled = true;
            FindObjectOfType<GameManager>().HomeOccupied();
        }
    }
}
