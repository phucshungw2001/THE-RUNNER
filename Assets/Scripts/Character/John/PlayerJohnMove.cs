using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJohnMove : MonoBehaviour
{
    [SerializeField]
    private FloatingJoystick joyStick;
    [SerializeField]
    private SpriteRenderer sprite;
    private Animator playerAnimator;

    Vector2 move;
    Rigidbody2D rb2D;

    public float moveSpeed = 2f;

    PlayerMove player = new PlayerMove();

    public CharacterJohn John;
    void Start()
    {
        Debug.Log("" + John.characterName);
        playerAnimator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move.x = joyStick.Horizontal;
        move.y = joyStick.Vertical;
    }

    private void FixedUpdate()
    {
        // Call funtion PlayerMoveCommon in class PlayerMove
        player.PlayerMoveCommon(playerAnimator, "Run", rb2D, move, sprite, moveSpeed);
    }
}
