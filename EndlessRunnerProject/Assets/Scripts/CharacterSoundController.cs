using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;

    private AudioSource audioPlayer;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }
}
