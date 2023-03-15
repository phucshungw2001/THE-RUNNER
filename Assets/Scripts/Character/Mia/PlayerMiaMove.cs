using UnityEngine;
using UnityEngine.UI;

public class PlayerMiaMove : MonoBehaviour
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

    // Index infomation character Mia
    public CharacterMia Mia;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Mia.blood = Mia.bloodMax;
        slider.value = Mia.blood;
        slider.maxValue = Mia.bloodMax;
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
            Mia.blood = Mia.blood - 2;
            slider.value = Mia.blood;
        }
    }

    private void FixedUpdate()
    {
        // Call funtion PlayerMoveCommon in class PlayerMove
        player.PlayerMoveCommon(playerAnimator, "Run", rb2D, move, sprite, Mia.moveSpeed);
    }
}
