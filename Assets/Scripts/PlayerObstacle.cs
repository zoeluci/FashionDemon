using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    public GameObject deathScreen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
