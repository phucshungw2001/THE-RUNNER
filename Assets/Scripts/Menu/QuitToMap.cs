using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitToMap : MonoBehaviour
{
    public GameObject _QuitToMap;
    // Start is called before the first frame update
    public void _QuitToMapPause()
    {
        _QuitToMap.SetActive(true);
    }

    // Update is called once per frame
    public void Continue()
    {
        _QuitToMap.SetActive(false);
    }
}
