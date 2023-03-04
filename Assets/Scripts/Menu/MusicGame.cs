using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour
{
    [SerializeField] AudioSource music; 
    // Start is called before the first frame update
    public void OnMusic()
    {
        music.Play();
    }
    public void OffMusic()
    {
        music.Stop(); 
    }
}
