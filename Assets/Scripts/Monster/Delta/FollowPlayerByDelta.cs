using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayerByDelta : MonoBehaviour
{
    private GameObject player;
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    public GameObject Delta;
    private bool InRange;
    [SerializeField] public Delta delta;
    [SerializeField] SpriteRenderer sprite;
    // Start is called before the first frame update
   

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
        if (Vector2.Distance(transform.position, player.transform.position) > delta.AttackRangea31)
        {
            InRange = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= delta.AttackRangea31)
        {

            InRange = false;
        }
    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, delta.Speed3 * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, delta.AttackRangea31);
        Gizmos.color = Color.red;
    }
}
