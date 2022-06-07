using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public Camera mainCamera;
    public Vector3 startPos = new Vector3(-31.53125f, 20.71875f, -32.03125f);
    public Quaternion startRotation = Quaternion.Euler(0f, -48.661f, 0f);
    public GameObject thirdPersonToggle;

    // Start is called before the first frame update
    public void Start()
    {
        thirdPersonToggle.SetActive(false);
        mainCamera.transform.position = startPos;
        mainCamera.transform.localRotation = startRotation;

        Time.timeScale = 0f;
        startMenuUI.SetActive(true);
    }

    public void PlayGame() {
        Time.timeScale = 1f;
        
        thirdPersonToggle.SetActive(true);
        startMenuUI.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }


}
