using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpDelta : MonoBehaviour
{
    [SerializeField] public Slider HP;
    [SerializeField] public StopWatch time;
    public CharacterJohn John;
    public CharacterMia Mia;
    public DeltaBoss boss;
    // Start is called before the first frame update
    void Start()
    {
        HP.maxValue = boss.BloodMax3;
        boss.Blood3 = boss.BloodMax3;
        HP.value = boss.Blood3;
    }


    // Update is called once per frame
    void Update()
    {      
        
        boss.BloodMax3 = 600 * (time.Minute / 5);
        boss.Damage3 = 15 * (time.Minute / 5);
        HP.maxValue = boss.BloodMax3;
        HP.value = boss.Blood3;

        if (boss.Blood3 <= 0 && time.TimeStart <= 0)
        {
            time.TimeStart = 1;
        }
    }
}
