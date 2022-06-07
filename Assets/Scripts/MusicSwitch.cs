using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{
    public AudioSource track;
    private AudioController audioController;

    private void Start() {
        audioController = FindObjectOfType<AudioController>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            if (track != null) {
                audioController.ChangeBGM(track);
            }
        }
    }
}
