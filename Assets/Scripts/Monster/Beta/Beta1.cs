using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beta1 : MonoBehaviour
{
    private float count;
    private float damageBe1 = 2;
    private float bloodBe1 = 15;
    private float speedBe1 = 1;
    private float attackSpeedBe1 = 3;
    private float expBe1 = 1;
    private float startTimeBtwShotsBe1 = 3;
    private float timeBtwShotsBe1 = 3;
    private float attackRangeBe1 = 4;
    private float attackSpeedBulletBe1 = 3;
    private float existenceTimeBulletBe1 = 1;

    private void Update()
    {
        count += Time.deltaTime;
        if (count >= 60)
        {
            count -= 60;
            damageBe1 += 1;
            bloodBe1 += 3;
        }
    }
    public float DamageBe11 { get => DamageBe1; set => DamageBe1 = value; }
    public float BloodBe11 { get => BloodBe1; set => BloodBe1 = value; }
    public float SpeedBe11 { get => SpeedBe1; set => SpeedBe1 = value; }
    public float AttackSpeedBe11 { get => AttackSpeedBe1; set => AttackSpeedBe1 = value; }
    public float ExpBe11 { get => ExpBe1; set => ExpBe1 = value; }
    public float StartTimeBtwShotsBe11 { get => StartTimeBtwShotsBe1; set => StartTimeBtwShotsBe1 = value; }
    public float TimeBtwShotsBe11 { get => TimeBtwShotsBe1; set => TimeBtwShotsBe1 = value; }
    public float AttackRangeBe11 { get => AttackRangeBe1; set => AttackRangeBe1 = value; }
    public float AttackSpeedBulletBe11 { get => AttackSpeedBulletBe1; set => AttackSpeedBulletBe1 = value; }
    public float ExistenceTimeBulletBe11 { get => ExistenceTimeBulletBe1; set => ExistenceTimeBulletBe1 = value; }
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
