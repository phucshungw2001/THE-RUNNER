using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    [SerializeField] public GameObject Al1;
    [SerializeField] public GameObject Al2;
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
    // Start is called before the first frame update
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


    // Update is called once per frame
    void Update()
    {
        CountTime += Time.deltaTime;
        timeCreate = (float)(60.01 / (60 + (time.Minute * 10)));
        if (CountTime >= timeCreate)
        {
            rate = Random.Range(1, 2);
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
            rate = Random.Range(0, 9);

            if (rate == 1 || rate == 2 || rate == 3 || rate == 4 || rate == 0)
            {
                MonsterObject.Add(Instantiate<GameObject>(Al1, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
            if (rate == 5)
            {
                MonsterObject.Add(Instantiate<GameObject>(Al2, new Vector3(xPosition, yPosition, 0), Quaternion.identity));
            }
        }
    }
}
