using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerByGamma : MonoBehaviour
{
    private GameObject player;
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    public GameObject Gamma;
    [SerializeField] GameObject bulletGamma;
    private bool InRange;
    [SerializeField] private Gamma gamma;
    [SerializeField] SpriteRenderer sprite;
    
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
        if (Vector2.Distance(transform.position, player.transform.position) > gamma.AttackRangeGa)
        {
            InRange = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= gamma.AttackRangeGa)
        {
            InRange = false;
            if (gamma.TimeBtwShotsGa <= 0)
            {
                Instantiate(bulletGamma, transform.position, Quaternion.Euler(0, 0, rotZ));
                gamma.TimeBtwShotsGa = gamma.StartTimeBtwShotsGa;
            }
            else
            {
                gamma.TimeBtwShotsGa -= Time.deltaTime;
            }
        }

    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, gamma.SpeedGa * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, gamma.AttackRangeGa);
        Gizmos.color = Color.red;
    }
}
