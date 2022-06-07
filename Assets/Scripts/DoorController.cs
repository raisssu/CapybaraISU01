using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator leftDoor;
    public Animator rightDoor;
    bool doorOpen;

    void Start() {
        doorOpen = false;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            doorOpen = true;
            leftDoor.SetTrigger("Open");
            rightDoor.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (doorOpen) {
            doorOpen = false;
            leftDoor.SetTrigger("Close");
            rightDoor.SetTrigger("Close");
        }
    }

}
