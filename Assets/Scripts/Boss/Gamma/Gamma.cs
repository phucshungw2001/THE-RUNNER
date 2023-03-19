using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamma : MonoBehaviour
{
    [SerializeField] private StopWatch time;
    private float count;
    private float damageGa = 10;
    private float bloodGa = 450;
    private float speedGa = 2;
    private float attackSpeedGa = 3;
    private float expGa = 500;
    private float startTimeBtwShotsGa = 3;
    private float timeBtwShotsGa = 0;
    private float attackRangeGa = 4;
    private float attackSpeedBulletGa = 3;
    private float existenceTimeBulletGa = 3;

    public float Count { get => count; set => count = value; }
    public float DamageGa { get => damageGa; set => damageGa = value; }
    public float BloodGa { get => bloodGa; set => bloodGa = value; }
    public float SpeedGa { get => speedGa; set => speedGa = value; }
    public float AttackSpeedGa { get => attackSpeedGa; set => attackSpeedGa = value; }
    public float ExpGa { get => expGa; set => expGa = value; }
    public float StartTimeBtwShotsGa { get => startTimeBtwShotsGa; set => startTimeBtwShotsGa = value; }
    public float TimeBtwShotsGa { get => timeBtwShotsGa; set => timeBtwShotsGa = value; }
    public float AttackRangeGa { get => attackRangeGa; set => attackRangeGa = value; }
    public float AttackSpeedBulletGa { get => attackSpeedBulletGa; set => attackSpeedBulletGa = value; }
    public float ExistenceTimeBulletGa { get => existenceTimeBulletGa; set => existenceTimeBulletGa = value; }

    private void Update()
    {
        Count += Time.deltaTime;
        damageGa = 10 * (Count / 300);
        damageGa = 10 * (time.Minute / 5);
    }
}
