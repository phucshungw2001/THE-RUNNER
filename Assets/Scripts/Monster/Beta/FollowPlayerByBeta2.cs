using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerByBeta2 : MonoBehaviour
{
    private GameObject player;
    public GameObject MonsterBe2;
    [SerializeField] GameObject bulletBe2;
    private bool InRange;
    [SerializeField] private Beta2 be2;
    [SerializeField] SpriteRenderer sprite;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
}
