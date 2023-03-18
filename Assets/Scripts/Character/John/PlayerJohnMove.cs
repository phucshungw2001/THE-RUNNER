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
    public bool isLevelUp;
    PlayerMove player = new PlayerMove();
    public Slider slider;
    public Slider expSlider;
    // Index infomation character John
    public CharacterJohn John;

    void Start()
    {   
        playerAnimator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        John.blood = John.bloodMax;
        slider.value = John.blood;
        slider.maxValue = John.bloodMax;
        John.level = 1;
        John.damage = 20;
        John.atkSpeed = 1.5f;
        John.exp = 0;
        John.expMax = 30;
        John.moveSpeed = 3;
        expSlider.value = John.exp;
        expSlider.maxValue = John.expMax;
        this.isLevelUp = false;
    }

    void Update()
    {
        move.x = joyStick.Horizontal;
        move.y = joyStick.Vertical;
    }
    public void AddExp(int exp)
    {
        John.exp += exp;
        expSlider.value = John.exp;
        expSlider.maxValue = John.expMax;
        if (John.exp >= John.expMax)
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        John.level++;
        John.exp = 0;
        John.expMax = John.expMax * 2;
        expSlider.value = John.exp;
        expSlider.maxValue = John.expMax;
        this.isLevelUp = true;
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
