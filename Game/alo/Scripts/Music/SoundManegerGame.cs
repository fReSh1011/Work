using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManegerGame : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource a; //звуки
    private AudioSource aa; //музыка
    public Slider valueSoundGame;
    private Slider valueMusicGame;
    public Toggle toggle;

    public void Awake()
    {
        valueMusicGame = GameObject.FindGameObjectWithTag("SliderMusic").GetComponent<Slider>();
        aa = GameObject.FindGameObjectWithTag("Bg_Music").GetComponent<AudioSource>();
        toggle.isOn = !NextScenes.onScreen;
        valueSoundGame.value = SoundManeger.value;
        valueMusicGame.value = MusicManeger.value;
    }

    private void Update()
    {
        a.volume = valueSoundGame.value;
        aa.volume = valueMusicGame.value;
    }
    public void PlaySound (int id)
    {
        a.clip = sound[id];
        a.Play();
    }
    public void ScreenMod()
    {
        Screen.fullScreen = !toggle.isOn;
    }
 }
