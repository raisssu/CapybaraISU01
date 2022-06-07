using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject infoCanvas;

    public void CloseUI(){
        Time.timeScale = 1f;
        GameObject[] infoArray = GameObject.FindGameObjectsWithTag("info");
        foreach (GameObject tagged in infoArray)
        {
            tagged.SetActive(false); // or true
        }
        infoCanvas.SetActive(false);        
    }
}
