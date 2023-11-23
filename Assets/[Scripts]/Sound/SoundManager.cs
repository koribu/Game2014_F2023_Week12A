using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class SoundManager : MonoBehaviour
{
    List<AudioSource> _channels;
    List<AudioClip> _audioClips;
    // Start is called before the first frame update
    void Start()
    {
        _channels = GetComponents<AudioSource>().ToList();
        _audioClips = new List<AudioClip>();

        LoadSounds();
  
    }

    void LoadSounds()
    {
        //SoundEffects
        _audioClips.Add(Resources.Load<AudioClip>("Sounds/Player_Hurt_SFX"));
        _audioClips.Add(Resources.Load<AudioClip>("Sounds/Player_Lose_SFX"));

        //Musixs
        _audioClips.Add(Resources.Load<AudioClip>("Sounds/Game_Music"));
        _audioClips.Add(Resources.Load<AudioClip>("Sounds/End_Music"));
    }


    public void PlaySound(Channel channel,Sound sound )
    {
        _channels[(int)channel].clip = _audioClips[(int)sound];
        _channels[(int)channel].Play();
    }
}
