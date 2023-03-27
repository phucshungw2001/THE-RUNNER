using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


public class DeltaAttack : MonoBehaviour
{

    public CharacterJohn John;
    public CharacterMia Mia;
    public DeltaBoss boss;
    private float hp = 0;
    public GameObject expDe;
    public float Hp { get => hp; set => hp = value; }
    // Start is called before the first frame update
    void Start()
    {
        hp = boss.BloodMax3;
        boss.Blood3 = boss.BloodMax3;
        Debug.Log("Delta: " + boss.Blood3);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            Instantiate(expDe, transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "blackHold")
        {
            hp -= John.damage;
            boss.Blood3 = hp;
        }
        if (collision.gameObject.tag == "fire")
        {
            hp -= Mia.damage;
            boss.Blood3 = hp;
        }
    }
}
