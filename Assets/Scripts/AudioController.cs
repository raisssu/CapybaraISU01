using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    public AudioSource src;
    public void ChangeBGM(AudioSource music) {
        if (src.name != music.name) {
            src.Stop();
            src = music;
            src.Play();
        }
    }

}
