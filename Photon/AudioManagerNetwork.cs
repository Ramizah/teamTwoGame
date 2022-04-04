using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;
using Photon.Pun;

public class AudioManagerNetwork : MonoBehaviour
{

    public SoundNetwork[] Sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(SoundNetwork s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        SoundNetwork s = Array.Find(Sounds, sound => sound.name == name);
        s.source.Play();
    }
}
