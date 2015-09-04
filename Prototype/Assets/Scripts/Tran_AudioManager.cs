using UnityEngine;
using System.Collections;

public class Tran_AudioManager : MonoBehaviour {

    public AudioSource manager;
    public AudioClip start_audioclip;
    public AudioClip exit_audioclip;
    public AudioClip shuffle_audioclip;
    public AudioClip mouseOnCard_audioclip;
    public AudioClip clickOnCard_audioclip;
    public AudioClip cardPlay_audioclip;
    
    void play_the_music(AudioClip music)
    {
        manager.loop = false;
        manager.clip = music;
        manager.Play();
        
    }
    
    public void Start_Audio()
    {
        play_the_music(start_audioclip);
    }
    public void Exit_Audio()
    {
        play_the_music(exit_audioclip);
    }

    public void Shuffle_Audio()
    {
        play_the_music(shuffle_audioclip);
    }

    public void MouseOnCard_Audio()
    {
        play_the_music(mouseOnCard_audioclip);
    }

    public void ClickOnCard_Audio()
    {
        play_the_music(clickOnCard_audioclip);
    }

    public void CardPlay_Audio()
    {
        play_the_music(cardPlay_audioclip);
    }
}
