using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

// Created by Caleb

public class AudioManager : MonoBehaviour
{

    //Should have at least 12 sounds by end of game (mostly in game scene, should check)

    public Sound[] Sounds;

    //KEEP ALL VOLUME AT 1 
    //KEEP ALL PITCH AT 1

    //IF ERROR, CHECK CLIP IS MP3 AND NOT WAV

    void Awake()
    {
        foreach(Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.Play();
    }
}
