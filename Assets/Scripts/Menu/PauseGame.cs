using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    public void Continue()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
