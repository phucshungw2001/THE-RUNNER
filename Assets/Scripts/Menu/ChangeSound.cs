using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ChangeSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        string text = File.ReadAllText(Application.dataPath + "/File/data.txt");
        int v = int.Parse(text);
        audioSource.volume = v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
