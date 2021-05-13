﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundEffects{
    Step, Pick, BowlingDrop, ShotGunFire, AxeBreakWood, TolietgirlKill, TolietgirlDead, RatKill, RatDead, CatKill, CatDead, DoorOpen, KeyOpen, Fridge
}

public class SoundManager : MonoBehaviour
{

    [SerializeField]
    public AudioSource effectSource, musicSource, stepSource;

    [SerializeField]
    AudioClip pick, bowlingDrop, shotGunFire, axeBreakWood, tolietgirlKill, tolietgirlDead, ratKill, ratDead, catKill, catDead, doorOpen, keyOpen, fridge;

    [SerializeField]
    List<AudioClip> steps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSound(SoundEffects sound)
    {
        switch(sound)
        {
            case SoundEffects.Step:
                effectSource.clip = steps[Random.Range(0, steps.Count)];
                effectSource.loop = false;
                break;
            case SoundEffects.Pick:
                effectSource.clip = pick;
                effectSource.loop = false;
                break;
            case SoundEffects.BowlingDrop:
                effectSource.clip = bowlingDrop;
                effectSource.loop = false;
                break;
            case SoundEffects.ShotGunFire:
                effectSource.clip = shotGunFire;
                effectSource.loop = false;
                break;
            case SoundEffects.AxeBreakWood:
                effectSource.clip = axeBreakWood;
                effectSource.loop = false;
                break;
            case SoundEffects.TolietgirlKill:
                effectSource.clip = tolietgirlKill;
                effectSource.loop = false;
                break;
            case SoundEffects.TolietgirlDead:
                effectSource.clip = tolietgirlDead;
                effectSource.loop = false;
                break;
            case SoundEffects.RatKill:
                effectSource.clip = ratKill;
                effectSource.loop = false;
                break;
            case SoundEffects.RatDead:
                effectSource.clip = ratDead;
                effectSource.loop = false;
                break;
            case SoundEffects.CatKill:
                effectSource.clip = catKill;
                effectSource.loop = false;
                break;
            case SoundEffects.CatDead:
                effectSource.clip = catDead;
                effectSource.loop = false;
                break;
            case SoundEffects.DoorOpen:
                effectSource.clip = doorOpen;
                effectSource.loop = false;
                break;
            case SoundEffects.KeyOpen:
                effectSource.clip = keyOpen;
                effectSource.loop = false;
                break;
            case SoundEffects.Fridge:
                effectSource.clip = fridge;
                effectSource.loop = false;
                break;
        }

        effectSource.Play();
    }
    public void playStepSound()
    {
        stepSource.clip = steps[Random.Range(0, steps.Count)];
        stepSource.loop = false;
        stepSource.Play();
    }
}
