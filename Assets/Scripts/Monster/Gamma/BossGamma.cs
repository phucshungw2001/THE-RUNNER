using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IndexInfomaionGamma", menuName = "BossGamma")]
public class BossGamma : ScriptableObject
{
    public float damageGa = 10;
    public float bloodGa = 450;
    public float bloodMaxGa = 450;
    public float speedGa = 2;
    public float attackSpeedGa = 3;
    public float expGa = 500;
    public float startTimeBtwShotsGa = 3;
    public float timeBtwShotsGa = 0;
    public float attackRangeGa = 4;
    public float attackSpeedBulletGa = 3;
    public float existenceTimeBulletGa = 3;
}
