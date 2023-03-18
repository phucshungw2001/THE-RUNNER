using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerByBeta1 : MonoBehaviour
{
    private GameObject player;
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    public GameObject MonsterBe1;
    [SerializeField] GameObject bulletBe1;
    private bool InRange;
    [SerializeField] private Beta1 be1;
    [SerializeField] SpriteRenderer sprite;
    //public GameObject expBe1;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerInf = FindObjectOfType<PlayerJohnMove>();
        playerInf2 = FindObjectOfType<PlayerMiaMove>();
        Vector3 differance = player.transform.position - transform.position;
        float rotZ = Mathf.Atan2(differance.y, differance.x) * Mathf.Rad2Deg;
        if (transform.position.x < player.transform.position.x)
        {
            sprite.flipX = false;
        }
        if (transform.position.x > player.transform.position.x)
        {
            sprite.flipX = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) > be1.AttackRangeBe1)
        {
            InRange = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= be1.AttackRangeBe1)
        {
            InRange = false;
            if (be1.TimeBtwShotsBe1 <= 0)
            {
                Instantiate(bulletBe1, transform.position, Quaternion.Euler(0, 0, rotZ));
                be1.TimeBtwShotsBe1 = be1.StartTimeBtwShotsBe1;
            }
            else
            {
                be1.TimeBtwShotsBe1 -= Time.deltaTime;
            }
        }

    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, be1.SpeedBe1 * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, be1.AttackRangeBe1);
        Gizmos.color = Color.red;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire" || collision.gameObject.tag == "blackHold")
        {
            if (playerInf != null)
            {
                playerInf.AddExp(10);
            }
            if (playerInf2 != null)
            {
                playerInf2.AddExp(10);
            }
            Destroy(gameObject);
            //Instantiate(expBe1, transform.position, Quaternion.identity);
        }
    }
}
