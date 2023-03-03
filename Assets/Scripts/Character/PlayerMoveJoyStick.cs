using UnityEngine;

public class PlayerMoveJoyStick : MonoBehaviour
{
    #region MovePlayer
    [SerializeField]
    private FloatingJoystick Joystick;
    Vector2 move;
    Rigidbody2D rb;
    public float moveSpeed = 2f;
    #endregion

    [SerializeField]
    private SpriteRenderer sprite;
    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator= GetComponent<Animator>();
        rb = gameObject.GetComponent < Rigidbody2D >();

    }

    // Update is called once per frame
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        playerAnimator.SetFloat("Run", Mathf.Abs(move.x));
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        if(move.x > 0)
        {
            sprite.flipX = false;
        }
        if (move.x < 0)
        {
            sprite.flipX = true;
        }
    }
}
