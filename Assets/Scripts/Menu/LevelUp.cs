using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    private PlayerJohnMove playerInf;
    private PlayerMiaMove playerInf2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInf = FindObjectOfType<PlayerJohnMove>();
        playerInf2 = FindObjectOfType<PlayerMiaMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "exp1")
        {
            if (playerInf != null)
            {
                playerInf.AddExp(1);
            }
            if (playerInf2 != null)
            {
                playerInf2.AddExp(1);
            }
        }
        if (collision.gameObject.tag == "exp5")
        {
            if (playerInf != null)
            {
                playerInf.AddExp(5);
            }
            if (playerInf2 != null)
            {
                playerInf2.AddExp(5);
            }
        }
        if (collision.gameObject.tag == "exp500")
        {
            if (playerInf != null)
            {
                playerInf.AddExp(500);
            }
            if (playerInf2 != null)
            {
                playerInf2.AddExp(500);
            }
        }
    }
}
