using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesItem : MonoBehaviour
{
    public GameObject clothesIcon;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            clothesIcon.SetActive(true);
            Destroy(gameObject);
        }
    }
}
