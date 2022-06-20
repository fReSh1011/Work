using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxExp(float expMax)
    {
        slider.maxValue = expMax;
    }

    public void SetExp(float exp)
    {
        slider.value = exp;
    }
}
