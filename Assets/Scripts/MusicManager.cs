using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    // Start is called before the first frame update
    
    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
    }
}
