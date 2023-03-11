using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IndexInfomaionPlayer", menuName = "Character")]
public class Character : ScriptableObject
{
    public string characterName;
    public Sprite SpriteRenderer;
    public float blood;
    public float bloodMax;
    public float level;
    public float exp;
    public float expMax;
    public float moveSpeed;
}
