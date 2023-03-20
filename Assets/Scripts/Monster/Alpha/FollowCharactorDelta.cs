using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharactorDelta : MonoBehaviour
{
    private GameObject player;
    public GameObject MonsterDe;
    [SerializeField] private Delta de1;
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
        if (Vector2.Distance(transform.position, player.transform.position) > de1.AttackRangea31)
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
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, de1.Speed3 * Time.deltaTime);

        }
    }
}
