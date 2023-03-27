using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerByBeta2 : MonoBehaviour
{
    private GameObject player;
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    public GameObject MonsterBe2;
    [SerializeField] GameObject bulletBe2;
    private bool InRange;
    [SerializeField] private Beta2 be2;
    [SerializeField] SpriteRenderer sprite;
    public GameObject expBe2;
    public DetroyMonterPoint p;
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
        if (Vector2.Distance(transform.position, player.transform.position) > be2.AttackRangeBe2)
        {
            InRange = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= be2.AttackRangeBe2)
        {
            InRange = false;
            if (be2.TimeBtwShotsBe2 <= 0)
            {
                Instantiate(bulletBe2, transform.position, Quaternion.Euler(0, 0, rotZ));
                be2.TimeBtwShotsBe2 = be2.StartTimeBtwShotsBe2;
            }
            else
            {
                be2.TimeBtwShotsBe2 -= Time.deltaTime;
            }
        }

        if (GameObject.FindGameObjectWithTag("boss") != null || GameObject.FindGameObjectWithTag("bossGa") != null)
        {
            Destroy(gameObject);
            Instantiate(expBe2, transform.position, Quaternion.identity);
        }

    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, be2.SpeedBe2 * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, be2.AttackRangeBe2);
        Gizmos.color = Color.red;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire" || collision.gameObject.tag == "blackHold")
        {
            Destroy(gameObject);
            Instantiate(expBe2, transform.position, Quaternion.identity);
            p.MonsterPoint = p.MonsterPoint + 1;
        }
    }
}
