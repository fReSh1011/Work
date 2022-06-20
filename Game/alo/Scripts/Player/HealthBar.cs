using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI infoHealthNow;
    public TextMeshProUGUI infoHealthMax;

    public void SetMaxHealth (float healthMax)
    {
        slider.maxValue = healthMax;
        slider.value = healthMax;
        infoHealthMax.text = healthMax.ToString();
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        infoHealthNow.text = Math.Round(health, 0).ToString();
    }
}
