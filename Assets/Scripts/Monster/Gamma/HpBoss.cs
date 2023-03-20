using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBoss : MonoBehaviour
{
    [SerializeField] public Slider HP;
    [SerializeField] public StopWatch time;
    public CharacterJohn John;
    public CharacterMia Mia;
    public BossGamma boss;
    // Start is called before the first frame update
    void Start()
    {
            HP.maxValue = boss.bloodMaxGa;
            boss.bloodGa = boss.bloodMaxGa;
            HP.value = boss.bloodGa;
    }

    void Update()
    {
            HP.value = boss.bloodGa;

            if (boss.bloodGa <= 0 && time.TimeStart <= 0)
            {
                time.TimeStart = 1;
            }
    }
}
