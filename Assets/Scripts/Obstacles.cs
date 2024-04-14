using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    bool isDamaged = false;
    public GameObject gameOverScreen;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            isDamaged = true;

        if (isDamaged)
        {
            gameOverScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
