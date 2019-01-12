using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSounds : MonoBehaviour
{

    public AudioSource source;
    // Start is called before the first frame update

    public void play_sound(AudioClip clip) {
        source.PlayOneShot(clip);
    }
}
