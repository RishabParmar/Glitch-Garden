using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        // Setting volume through Player Prefernces
        source.volume = PlayerPrefsController.GetVolume();
    }
}
