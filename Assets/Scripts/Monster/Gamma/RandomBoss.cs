using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RandomBoss : MonoBehaviour
{
    [SerializeField] public GameObject Gamma;
    [SerializeField] public GameObject Delta;
    [SerializeField] private StopWatch time;
    [SerializeField] public GameObject main;
    [SerializeField] public GameObject HPBoss;
    [SerializeField] public GameObject HPBossGamma;
    private BossGamma gamma;
    private DeltaBoss delta;
    private int count = 1;
    int a = 5;
    int rate;
    float xPosition = 0;
    float yPosition = 0;
    float screenWidth;
    float screenHeight;
    float screenLeft;
    float screenRight;
    float screenTop;

    void Start()
    {
    }

    List<GameObject> MonsterObject = new List<GameObject>();

    void Update()
    {

        if ((int)time.Minute == a && count == 1)
        {
            screenWidth = Screen.width;

            screenHeight = Screen.height;


            float screenZ = -Camera.main.transform.position.z;

            Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);

            Vector3 upperRightCornerScreen = new Vector3(

                screenWidth, screenHeight, screenZ);

            Vector3 lowerLeftCornerWorld =

                Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);

            Vector3 upperRightCornerWorld =

                Camera.main.ScreenToWorldPoint(upperRightCornerScreen);

            screenLeft = lowerLeftCornerWorld.x;

            screenRight = upperRightCornerWorld.x;

            screenTop = upperRightCornerWorld.y;
            main.SetActive(false);

            xPosition = Random.Range((screenLeft+screenRight)/2, (screenLeft + screenRight) / 2);
            yPosition = Random.Range(screenTop, (screenTop-1));
            rate = Random.Range(1, 3);
            if (rate == 1)
            {
                MonsterObject.Add(Instantiate<GameObject>(Gamma, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            if (rate == 2)
            {
                MonsterObject.Add(Instantiate<GameObject>(Delta, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            count = 0;
            a += 5;
        }

        if (GameObject.FindGameObjectWithTag("boss") != null)
        {

            HPBoss.SetActive(true);
        }
        if (GameObject.FindGameObjectWithTag("bossGa") != null)
        {
            HPBossGamma.SetActive(true);
        }


        if (GameObject.FindGameObjectWithTag("boss") == null && count == 0 && GameObject.FindGameObjectWithTag("bossGa") == null)
        {
            count = 1;
            main.SetActive(true);
            HPBoss.SetActive(false);
            HPBossGamma.SetActive(false);
        }

    } 
}
