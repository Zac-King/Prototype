using UnityEngine;
using System.Collections;

public class Tran_AudioManager : MonoBehaviour {

    public AudioSource manager;
    public AudioClip start;
    public AudioClip exit;
    public AudioClip shuffle;
    public AudioClip mouseOnCard;
    public AudioClip clickOnCard;
    public AudioClip cardPlay;
    public AudioClip drawCard;

    void play_the_music(AudioClip music)
    {
        manager.loop = false;
        manager.clip = music;
        manager.Play();
        
    }
    
    public void Start_Audio()
    {
        play_the_music(start);
    }
    public void Exit_Audio()
    {
        play_the_music(exit);
    }

    public void Shuffle_Audio()
    {
        play_the_music(shuffle);
    }

    public void MouseOnCard_Audio()
    {
        play_the_music(mouseOnCard);
    }

    public void ClickOnCard_Audio()
    {
        play_the_music(clickOnCard);
    }

    public void CardPlay_Audio()
    {
        play_the_music(cardPlay);
    }

    public void DrawCard_Audio()
    {
        play_the_music(drawCard);
    }
}
