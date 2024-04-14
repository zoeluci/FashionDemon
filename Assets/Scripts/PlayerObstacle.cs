using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    public GameObject gameOverScreen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
