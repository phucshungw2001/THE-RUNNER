using UnityEngine;
using UnityEngine.UI;

public class PlayerMove
{
    #region PlayerMove
    public void PlayerMoveCommon(Animator playerAnimator,string run
                    , Rigidbody2D rb, Vector2 move, SpriteRenderer sprite,float moveSpeed)
    {
        playerAnimator.SetFloat(run, Mathf.Abs(move.x));
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        if (move.x > 0)
        {
            sprite.flipX = false;
        }
        if (move.x < 0)
        {
            sprite.flipX = true;
        }
    }


    #endregion
    public void SetHealth(Slider slider, float health, float maxhealth)
    {
        slider.gameObject.SetActive(health < maxhealth);
        slider.value = health;
        slider.maxValue = maxhealth;

    }
}
