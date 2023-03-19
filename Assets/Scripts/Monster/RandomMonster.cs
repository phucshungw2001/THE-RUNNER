using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomMonster : MonoBehaviour
{
    [SerializeField] public GameObject Al1;
    [SerializeField] public GameObject Al2;
    [SerializeField] public GameObject Be1;
    [SerializeField] public GameObject Be2;
    [SerializeField] public Beta1 B1;
    [SerializeField] public Beta2 B2;
    [SerializeField] public Gamma Ga;
    private float timeCreate;
    [SerializeField] private StopWatch time;
    private float CountTime;
    int rate;

    float xPosition = 0;
    float yPosition = 0;
    float screenWidth;
    float screenHeight;
    float screenLeft;
    float screenRight;
    float screenTop;
    float screenBottom;

    void Start()
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

        screenBottom = lowerLeftCornerWorld.y;
    }

    List<GameObject> MonsterObject = new List<GameObject>();

    void Update()
    {
        B1.DamageBe1 = 2 + time.Minute;
        B2.DamageBe2 = 4 + time.Minute;
        Ga.DamageGa = 10 + (time.Minute / 5);
        Ga.BloodGa = 450 + (time.Minute / 5);
        CountTime += Time.deltaTime;
        timeCreate = (float)(60.01 / (60 + (time.Minute * 10)));
        if (CountTime >= timeCreate && GameObject.FindGameObjectWithTag("Boss") == null)
        {
            rate = Random.Range(1, 4);
            if (rate == 1)
            {
                xPosition = Random.Range(screenLeft, (screenLeft + 1));
                yPosition = Random.Range(screenBottom, screenTop);
            }
            if (rate == 2)
            {
                xPosition = Random.Range(screenLeft, screenRight);
                yPosition = Random.Range((screenTop - 1), screenTop);
            }
            if (rate == 3)
            {
                xPosition = Random.Range((screenRight - 1), screenRight);
                yPosition = Random.Range(screenBottom, screenTop);
            }
            if (rate == 4)
            {
                xPosition = Random.Range(screenLeft, screenRight);
                yPosition = Random.Range(screenBottom, (screenBottom + 1));
            }
            rate = Random.Range(0, 10);
            if (rate == 1 || rate == 2 || rate == 3 || rate == 4 || rate == 0)
            {
                MonsterObject.Add(Instantiate<GameObject>(Al1, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            if (rate == 5)
            {
                MonsterObject.Add(Instantiate<GameObject>(Al2, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            if (rate == 6 || rate == 7 || rate == 8)
            {
                MonsterObject.Add(Instantiate<GameObject>(Be1, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            if (rate == 9)
            {
                MonsterObject.Add(Instantiate<GameObject>(Be2, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            CountTime = 0;
        }
    }   
}
