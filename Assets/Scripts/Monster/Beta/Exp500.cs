using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp500 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
