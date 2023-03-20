using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHold : MonoBehaviour
{
    Timer blackHold_timer;
    public CharacterJohn John;
    // Start is called before the first frame update
    void Start()
    {
        blackHold_timer = gameObject.AddComponent<Timer>();
        blackHold_timer.Duration = (float)1.5;
        blackHold_timer.Run();
        if (John.level >= 5 && John.level < 10)
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
        }
        if(John.level >= 10) {
            gameObject.transform.localScale = new Vector3((float)2.5, (float)2.5, (float)2.5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (blackHold_timer.Finished)
        {
            Destroy(gameObject);
        }
    }
}
