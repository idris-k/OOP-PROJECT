using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip deathInvader;
    public AudioClip deathMystery;
    public AudioClip deathPlayer;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }




    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}