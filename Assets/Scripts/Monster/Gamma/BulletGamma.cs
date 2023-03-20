using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGamma : MonoBehaviour
{
    [SerializeField] private Gamma gamma;

    void Start()
    {
        Invoke("DestroyBulletBe1", gamma.ExistenceTimeBulletGa);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * gamma.AttackSpeedBulletGa * Time.deltaTime);
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
