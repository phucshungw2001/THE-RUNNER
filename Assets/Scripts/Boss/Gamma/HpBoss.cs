using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBoss : MonoBehaviour
{
    [SerializeField] public Gamma gamma;
    [SerializeField] public Slider HP;
    [SerializeField] public StopWatch time;
    public CharacterJohn John;
    public CharacterMia Mia;
    public BossGamma boss;
    // Start is called before the first frame update
    void Start()
    {
        HP.maxValue = boss.bloodMax;
        boss.bloodGa = boss.bloodMax;
      }

    void Update()
    {
        HP.value = boss.bloodGa;

        if (HP.value <= 0 && time.TimeStart <= 0)
        {
            time.TimeStart = 1;
        }
    }
}
