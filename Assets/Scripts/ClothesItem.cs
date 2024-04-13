using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesItem : MonoBehaviour
{
    bool isCollected = false;
    public GameObject clothesIcon;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            isCollected = true;

        if (isCollected)
        {
            clothesIcon.SetActive(true);
            Destroy(gameObject);
        }
    }
}
