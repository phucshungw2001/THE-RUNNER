using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    private int minute = 0;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = minute + " : " + timeStart.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        if (timeStart >= 60)
        {
            timeStart = timeStart - 60;
            minute += 1;
        }
        textBox.text = minute + " : " + timeStart.ToString("F0");
    }
}