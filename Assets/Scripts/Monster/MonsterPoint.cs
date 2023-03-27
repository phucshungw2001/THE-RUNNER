using System.Drawing;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MonsterPoint : MonoBehaviour
{
    public DetroyMonterPoint p;
    public Text Point;
    // Start is called before the first frame update
    void Start()
    {
        p.MonsterPoint = 0;
        Point.text = "" + p.MonsterPoint;
    }

    // Update is called once per frame
    void Update()
    {
        Point.text = "" + p.MonsterPoint;
    }
}
