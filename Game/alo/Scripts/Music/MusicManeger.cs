using UnityEngine;
using UnityEngine.UI;

public class MusicManeger : MonoBehaviour
{
    [SerializeField] public AudioSource a;
    public Slider valueMusic;
    [SerializeField] public static float value = 1f;

    void Start()
    {
        valueMusic = GameObject.FindGameObjectWithTag("SliderMusic").GetComponent<Slider>();
        valueMusic.value = value;
    }

    private void LateUpdate()
    {
        if (valueMusic != null)
        {
            a.volume = valueMusic.value;
            value = valueMusic.value;
        }
    }
}
