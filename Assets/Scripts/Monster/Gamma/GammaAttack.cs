using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GammaAttack : MonoBehaviour
{
    
    public CharacterJohn John;
    public CharacterMia Mia;
    public BossGamma boss;
    private float hp = 0;
    public GameObject expGa;
    public float Hp { get => hp; set => hp = value; }

    // Start is called before the first frame update
    void Start()
    {
        hp = boss.bloodMaxGa;
        boss.bloodGa = boss.bloodMaxGa;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            Instantiate(expGa, transform.position, Quaternion.identity);
        }
        
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
}
