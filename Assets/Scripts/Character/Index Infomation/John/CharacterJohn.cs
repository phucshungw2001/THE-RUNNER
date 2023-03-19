using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IndexInfomaionCharacterJohn", menuName = "CharacterJohn")]
public class CharacterJohn : ScriptableObject
{
    public string characterName;
    public float blood;
    public float bloodMax;
    public float level;
    public float exp;
    public float expMax;
    public float moveSpeed;
    public float damage;
    public float atkSpeed;
    public float bulletSpeed; 
}
