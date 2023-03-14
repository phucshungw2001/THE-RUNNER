using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] SoundManager sound;
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        audioSource.volume = sound.Volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
