using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject visualEffectHit;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        if (visualEffectHit == null) {
            Debug.LogWarning("Visual Effect is not attached!");
        }

        if (clip == null)
            Debug.LogWarning("Audio clip is empty. Please attach a sound effect.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform ts = other.gameObject.GetComponent<Transform>();
        GameObject effect = Instantiate(visualEffectHit, ts, true);
        GameObject.Find("AudioSourceFX").GetComponent<EffectsSounds>().play_sound(clip);
        Destroy(gameObject);
        Destroy(effect, 2.0f);
        
    }
}
