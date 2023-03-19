using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public void SetHealth(Slider slider, float health, float maxhealth)
    {
        health = maxhealth;
        slider.value = health;
        slider.maxValue = maxhealth;
    }

}
