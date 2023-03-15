using UnityEngine;
using UnityEngine.UI;

public class PlayerJohnMove : MonoBehaviour
{
    [SerializeField]
    private FloatingJoystick joyStick;
    [SerializeField]
    private SpriteRenderer sprite;
    private Animator playerAnimator;

    Vector2 move;
    Rigidbody2D rb2D;

    PlayerMove player = new PlayerMove();


    public Slider slider;

    // Index infomation character John
    public CharacterJohn John;

    void Start()
    {   
        playerAnimator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        John.blood = John.bloodMax;
        slider.value = John.blood;
        slider.maxValue = John.bloodMax;
    }

    void Update()
    {
        move.x = joyStick.Horizontal;
        move.y = joyStick.Vertical;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            John.blood = John.blood - 2;
            slider.value = John.blood;
        }
    }


    private void FixedUpdate()
    {
        // Call funtion PlayerMoveCommon in class PlayerMove
        player.PlayerMoveCommon(playerAnimator, "Run", rb2D, move, sprite, John.moveSpeed);
    }
}
