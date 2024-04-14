using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject hatIcon;
    public GameObject trousersIcon;
    public GameObject shirtIcon;
    public GameObject bootsIcon;
    public GameObject winScreen;
    void Update()
    {
        if(hatIcon.activeInHierarchy && trousersIcon.activeInHierarchy && shirtIcon.activeInHierarchy && bootsIcon.activeInHierarchy)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
