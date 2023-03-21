using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "IndexInfomaionDelta", menuName = "DeltaBoss")]
public class DeltaBoss : ScriptableObject
{
    private float damage3 = 15;
    private float bloodMax3 = 600;
    private float blood3 = 600;
    private float speed3 = 1;
    private float attackSpeed3 = 1;
    private float exp3 = 4;
    private float attackRangea3 = 1;

    public float Damage3 { get => damage3; set => damage3 = value; }
    public float BloodMax3 { get => bloodMax3; set => bloodMax3 = value; }
    public float Blood3 { get => blood3; set => blood3 = value; }
    public float Speed3 { get => speed3; set => speed3 = value; }
    public float AttackSpeed3 { get => attackSpeed3; set => attackSpeed3 = value; }
    public float Exp3 { get => exp3; set => exp3 = value; }
    public float AttackRangea3 { get => attackRangea3; set => attackRangea3 = value; }
}
