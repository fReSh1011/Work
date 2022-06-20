using UnityEngine;
using UnityEngine.UI;

public class SoundManeger : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource a;
    public Slider valueMusic;
    [SerializeField] public static float value = 1f;

    void Start()
    {
        valueMusic.value = SoundManeger.value;
    }

    private void Update()
    {
        a.volume = valueMusic.value;
        value = valueMusic.value;
        if (Input.GetMouseButtonDown(0))
        {
            a.clip = sound[0];
            a.Play();
        }
    }
}
