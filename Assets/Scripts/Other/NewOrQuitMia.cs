using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewOrQuitMia : MonoBehaviour
{
    public CharacterMia Mia;
    public GameObject NewOrQuit;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Mia.blood <= 0)
        {
            NewOrQuit.SetActive(true);
            Mia.blood = 1;
            Time.timeScale = 0;
        }
    }

}
