using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerByBeta1 : MonoBehaviour
{
    public Transform player;
    /*public Transform shotpoint;
    public Transform gun;*/
    public GameObject MonsterBe1;
    private bool InRange;
    [SerializeField] private Beta1 be1;

    // Update is called once per frame
    void Update()
    {
        /*Vector3 Differance = player.position - gun.transform.position;
        float rotZ = Mathf.Atan2(Differance.y, Differance.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0f, 0f, rotZ);*/
        if (Vector2.Distance(transform.position, player.position) > be1.AttackRangeBe1)
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
            transform.position = Vector2.MoveTowards(transform.position, player.position, be1.SpeedBe1 * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, be1.AttackRangeBe1);
        Gizmos.color = Color.red;
        
    }
}
