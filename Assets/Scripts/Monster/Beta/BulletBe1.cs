using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBe1 : MonoBehaviour
{
    [SerializeField] private Beta1 be1;

    void Start()
    {
        Invoke("DestroyBulletBe1", be1.ExistenceTimeBulletBe1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * be1.AttackSpeedBulletBe1 * Time.deltaTime);
    }
     
    void DestroyBulletBe1()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
