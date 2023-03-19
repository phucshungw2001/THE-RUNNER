using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beta1 : MonoBehaviour
{
    [SerializeField] private StopWatch time;
    private float count;
    private float damageBe1 = 2;
    private float bloodBe1 = 15;
    private float speedBe1 = 2;
    private float attackSpeedBe1 = 3;
    private float expBe1 = 1;
    private float startTimeBtwShotsBe1 = 3;
    private float timeBtwShotsBe1 = 0;
    private float attackRangeBe1 = 4;
    private float attackSpeedBulletBe1 = 3;
    private float existenceTimeBulletBe1 = 3;

    private void Update()
    {
        damageBe1 = 2 + time.Minute;
    }
    public float DamageBe1 { get => damageBe1; set => damageBe1 = value; }
    public float BloodBe1 { get => bloodBe1; set => bloodBe1 = value; }
    public float SpeedBe1 { get => speedBe1; set => speedBe1 = value; }
    public float AttackSpeedBe1 { get => attackSpeedBe1; set => attackSpeedBe1 = value; }
    public float ExpBe1 { get => expBe1; set => expBe1 = value; }
    public float StartTimeBtwShotsBe1 { get => startTimeBtwShotsBe1; set => startTimeBtwShotsBe1 = value; }
    public float TimeBtwShotsBe1 { get => timeBtwShotsBe1; set => timeBtwShotsBe1 = value; }
    public float AttackRangeBe1 { get => attackRangeBe1; set => attackRangeBe1 = value; }
    public float AttackSpeedBulletBe1 { get => attackSpeedBulletBe1; set => attackSpeedBulletBe1 = value; }
    public float ExistenceTimeBulletBe1 { get => existenceTimeBulletBe1; set => existenceTimeBulletBe1 = value; }
}
