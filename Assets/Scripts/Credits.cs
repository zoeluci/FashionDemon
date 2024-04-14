using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject creditsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (creditsPanel.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            creditsPanel.SetActive(false);
        }
    }
}
