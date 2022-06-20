using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ManaBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI infoManaNow;
    public TextMeshProUGUI infoManaMax;

    public void SetMaxMana(float manaMax)
    {
        slider.maxValue = manaMax;
        slider.value = manaMax;
        infoManaMax.text = manaMax.ToString();
    }

    public void SetMana(float manaNow)
    {
        slider.value = manaNow;
        infoManaNow.text = Math.Round(manaNow, 0).ToString();
    }
}
