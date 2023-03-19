using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewOrQuitgame : MonoBehaviour
{
    public CharacterJohn John;
    public GameObject NewOrQuit;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(John.blood <= 0)
        {
            NewOrQuit.SetActive(true);
            John.blood = 1;
            Time.timeScale = 0;
        }
    }

}
