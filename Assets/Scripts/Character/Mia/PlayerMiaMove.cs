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
    public bool isLevelUp;
    PlayerMove player = new PlayerMove();
    public Slider slider;
    public Slider expSlider;
    // Index infomation character Mia
    public CharacterMia Mia;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Mia.level = 1;
        Mia.bloodMax = 80;
        Mia.blood = Mia.bloodMax;
        slider.value = Mia.blood;
        slider.maxValue = Mia.bloodMax;
        Mia.exp = 0;
        Mia.damage = 20;
        Mia.atkSpeed = 1f;
        Mia.expMax = 30;
        Mia.moveSpeed = 4;
        Mia.bulletSpeed = 9;
        expSlider.value = Mia.exp;
        expSlider.maxValue = Mia.expMax;
        this.isLevelUp = false;
    }

    void Update()
    {
        move.x = joyStick.Horizontal;
        move.y = joyStick.Vertical;
    }
    public void AddExp(int exp)
    {
        Mia.exp += exp;
        expSlider.value = Mia.exp;
        expSlider.maxValue = Mia.expMax;
        if (Mia.exp >= Mia.expMax)
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        Mia.level++;
        Mia.exp = 0;
        Mia.expMax = Mia.level * (Mia.level - 1) * 10 + 30;
        expSlider.value = Mia.exp;
        expSlider.maxValue = Mia.expMax;
        this.isLevelUp = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster" || collision.gameObject.tag == "bulletBe1" 
            || collision.gameObject.tag == "bulletBe2")
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
