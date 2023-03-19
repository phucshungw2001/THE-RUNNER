using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    private float timeStart;
    public Text textBox;
    private int minute = 0;

    public int Minute { get => minute; set => minute = value; }
    public float TimeStart { get => timeStart; set => timeStart = value; }


    // Start is called before the first frame update
    void Start()
    {
        textBox.text = minute + " : " + timeStart.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Boss") == null)
        {
            timeStart += Time.deltaTime;
            if (timeStart >= 60)
            {
                timeStart -= 60;
                minute += 1;
            }
            textBox.text = minute + " : " + timeStart.ToString("F0");
        }
    }
}