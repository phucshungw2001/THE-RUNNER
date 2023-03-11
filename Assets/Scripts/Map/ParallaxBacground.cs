using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBacground : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxEffect;
    private Transform cameraTranform;
    private Vector3 lastCameraPossition;
    private float posssitionX;
    private float posssitionY;
    [SerializeField] private bool infiniteVertical;
    [SerializeField] private bool infiniteHorizontal;


    // Start is called before the first frame update
    void Start()
    {
        cameraTranform = Camera.main.transform;
        lastCameraPossition = cameraTranform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        posssitionX = texture.width / sprite.pixelsPerUnit;
        posssitionY = texture.height / sprite.pixelsPerUnit;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 delta = cameraTranform.position - lastCameraPossition;
        transform.position += new Vector3(delta.x * parallaxEffect.x, delta.y * parallaxEffect.y);
        lastCameraPossition = cameraTranform.position;
        if (infiniteHorizontal)
        {


            if (Mathf.Abs(cameraTranform.position.x - transform.position.x) >= posssitionX)
            {
                float offset = (cameraTranform.position.x - transform.position.x) % posssitionX;
                transform.position = new Vector3(cameraTranform.position.x + offset, transform.position.y);
            }
        }
        if (infiniteVertical)
        {

            if (Mathf.Abs(cameraTranform.position.y - transform.position.y) >= posssitionY)
            {
                float offset = (cameraTranform.position.y - transform.position.y) % posssitionY;
                transform.position = new Vector3(transform.position.x, cameraTranform.position.y + offset);
            }
        }
    }
}
