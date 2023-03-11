using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IndexInfomaionCharacterMia", menuName = "CharacterMia")]
public class CharacterMia : ScriptableObject
{
    public string characterName;
    public float blood;
    public float bloodMax;
    public float level;
    public float exp;
    public float expMax;
    public float moveSpeed;
}
