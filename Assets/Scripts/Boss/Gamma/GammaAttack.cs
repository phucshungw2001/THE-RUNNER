using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GammaAttack : MonoBehaviour
{
    private float hp;
    public CharacterJohn John;
    public CharacterMia Mia;
    public BossGamma boss;
    // Start is called before the first frame update
    void Start()
    {
        hp = boss.bloodMax;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log(hp);
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "blackHold")
        {
            hp -= John.damage;
            boss.bloodGa = hp;
        }
        if (collision.gameObject.tag == "fire")
        {
            hp -= Mia.damage;
            boss.bloodGa = hp;
        }
    }
    public float Hp { get => hp; set => hp = value; }
}
