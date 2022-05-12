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

// *Title: How to make Frogger in Unity (Complete Tutorial)  
// *Author: Zigurous
// *Date: Oct 21, 2021 
// * Code version: V1 
// *Availability: https://www.youtube.com/watch?v=GxlxZ5q__Tc&t=304s (Accessed 24 April 2022) 