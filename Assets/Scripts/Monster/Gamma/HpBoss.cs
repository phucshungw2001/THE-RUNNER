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
    {   boss.bloodGa = boss.bloodMaxGa;
        HP.maxValue = boss.bloodMaxGa;
        HP.value = boss.bloodGa;
    }

    void Update()
    {
        boss.bloodMaxGa = 450 * (time.Minute / 5);
        boss.damageGa = 10 * (time.Minute / 5);
        HP.maxValue = boss.bloodMaxGa;
        HP.value = boss.bloodGa;
        if (boss.bloodGa <= 0 && time.TimeStart <= 0)
        {
            time.TimeStart = 1;
        }
    }
}
