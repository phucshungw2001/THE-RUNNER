using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBe2 : MonoBehaviour
{
    [SerializeField] private Beta2 be2;

    void Start()
    {
        Invoke("DestroyBulletBe2", be2.ExistenceTimeBulletBe2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * be2.AttackSpeedBulletBe2 * Time.deltaTime);
    }

    void DestroyBulletBe2()
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
