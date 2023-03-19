using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHold : MonoBehaviour
{
    Timer blackHold_timer;
    // Start is called before the first frame update
    void Start()
    {
        blackHold_timer = gameObject.AddComponent<Timer>();
        blackHold_timer.Duration = (float)1.5;
        blackHold_timer.Run();
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
