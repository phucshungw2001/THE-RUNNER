using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void LoadGameMap1(int index)
    {
        SceneManager.LoadSceneAsync(index,LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
