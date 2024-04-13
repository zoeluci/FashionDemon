using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    bool isCollected = false;
    public GameObject clothesIcon;
    // Update is called once per frame
    void Update()
    {

    }

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
