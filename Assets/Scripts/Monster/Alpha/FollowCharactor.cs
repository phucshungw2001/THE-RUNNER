using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class FollowCharactor : MonoBehaviour
{
    private GameObject player;
    public GameObject Monstera1;
    [SerializeField] private Alpha al1;
    [SerializeField] SpriteRenderer sprite;
    bool InRange;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (transform.position.x < player.transform.position.x)
        {
            sprite.flipX = false;
        }
        if (transform.position.x > player.transform.position.x)
        {
            sprite.flipX = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) > al1.AttackRangea11)
        {
            InRange = true;
        }
        else
        {
            InRange = false;
        }
    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, al1.Speed1 * Time.deltaTime);

        }
    }
}
