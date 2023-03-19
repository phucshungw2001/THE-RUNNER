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
        John.bloodMax = 100;
        John.level = 1;
        John.blood = John.bloodMax;
        slider.value = John.blood;
        slider.maxValue = John.bloodMax;
        John.damage = 20;
        John.atkSpeed = 1.5f;
        John.exp = 0;
        John.expMax = 30;
        John.moveSpeed = 3;
        John.bulletSpeed = 6;
        expSlider.value = John.exp;
        expSlider.maxValue = John.expMax;
        this.isLevelUp = false;
    }

    void Update()
    {
        move.x = joyStick.Horizontal;
        move.y = joyStick.Vertical;

        if(John.blood <= 0)
        {
            Time.timeScale = 0;

        }
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
        John.expMax = John.level * (John.level - 1) * 10 + 30;
        expSlider.value = John.exp;
        expSlider.maxValue = John.expMax;
        this.isLevelUp = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster" || collision.gameObject.tag == "bulletBe1"
            || collision.gameObject.tag == "bulletBe2")
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
