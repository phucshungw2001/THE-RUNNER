using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharactorA2 : MonoBehaviour
{
    private GameObject player;
    public GameObject Monstera2;
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    [SerializeField] private Alpha2 al2;
    [SerializeField] SpriteRenderer sprite;
    bool InRange;
    public GameObject expBe1;
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");


        playerInf = FindObjectOfType<PlayerJohnMove>();
        playerInf2 = FindObjectOfType<PlayerMiaMove>();

        if (transform.position.x < player.transform.position.x)
        {
            sprite.flipX = false;
        }
        if (transform.position.x > player.transform.position.x)
        {
            sprite.flipX = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) > al2.AttackRangea21)
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
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, al2.Speed2 * Time.deltaTime);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire" || collision.gameObject.tag == "blackHold")
        {
            Destroy(gameObject);
            Instantiate(expBe1, transform.position, Quaternion.identity);
        }
    }
}
