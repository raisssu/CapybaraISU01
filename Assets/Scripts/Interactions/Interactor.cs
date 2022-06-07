using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{
    public float hitDistance = 5f;
    public Camera cam;
    public LayerMask interactableLayerMask;
    public Interactable interactable;
    public GameObject UI;
    public float rayThickness = 0.5f;
    public GameObject infoUI;
    public Scrollbar scrollbar;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.SphereCast(cam.transform.position, rayThickness, cam.transform.forward, out hit, hitDistance, interactableLayerMask)){
            UI.SetActive(true);
            if(hit.collider.GetComponent<Interactable>()){


                if(interactable == null || interactable.ID != hit.collider.GetComponent<Interactable>().ID){
                    interactable = hit.collider.GetComponent<Interactable>();
                    Debug.Log("Hi");
                }
                if(Input.GetKeyDown(KeyCode.E)){
                    if (hit.collider.GetComponent<Interactable>().tag != "pole") {
                        Time.timeScale = 0f;
                        infoUI.SetActive(true);
                    }
                    interactable.onInteract.Invoke();
                    scrollbar.value = 1;
                }
            }

        }
        else{
            UI.SetActive(false);
        }
    }
}
