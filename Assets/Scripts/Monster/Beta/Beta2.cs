using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beta2 : MonoBehaviour
{
    [SerializeField] private StopWatch time;
    private float count;
    private float damageBe2 = 4;
    private float bloodBe2 = 15;
    private float speedBe2 = 2;
    private float attackSpeedBe2 = 3;
    private float expBe2 = 5;
    private float startTimeBtwShotsBe2 = 3;
    private float timeBtwShotsBe2 = 0;
    private float attackRangeBe2 = 4;
    private float attackSpeedBulletBe2 = 3;
    private float existenceTimeBulletBe2 = 3;

    public float Count { get => count; set => count = value; }
    public float DamageBe2 { get => damageBe2; set => damageBe2 = value; }
    public float BloodBe2 { get => bloodBe2; set => bloodBe2 = value; }
    public float SpeedBe2 { get => speedBe2; set => speedBe2 = value; }
    public float AttackSpeedBe2 { get => attackSpeedBe2; set => attackSpeedBe2 = value; }
    public float ExpBe2 { get => expBe2; set => expBe2 = value; }
    public float StartTimeBtwShotsBe2 { get => startTimeBtwShotsBe2; set => startTimeBtwShotsBe2 = value; }
    public float TimeBtwShotsBe2 { get => timeBtwShotsBe2; set => timeBtwShotsBe2 = value; }
    public float AttackRangeBe2 { get => attackRangeBe2; set => attackRangeBe2 = value; }
    public float AttackSpeedBulletBe2 { get => attackSpeedBulletBe2; set => attackSpeedBulletBe2 = value; }
    public float ExistenceTimeBulletBe2 { get => existenceTimeBulletBe2; set => existenceTimeBulletBe2 = value; }

    private void Update()
    {
        damageBe2 = 4 + time.Minute;
    }
}
