using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightJohn : MonoBehaviour
{
    public FloatingJoystick joystick;
    Vector2 move;
    [SerializeField]
    private SpriteRenderer Sprite;

    public GameObject bulletPrefab;
    public Transform gunPosition; // Vị trí đuôi súng
    public Transform gunTip; // Vị trí đầu súng
    private float timeCreate;

    public CharacterJohn John;
    private void Start()
    {

    }
    private void Update()
    {
        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;
    }
    void FixedUpdate()
    {
        Weapon();
        onClickBullet();

    }

    private void Weapon()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        // Tính toán góc quay của đối tượng và thay đổi hướng quay của một đối tượng
        float angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (move.x > 0)
        {
            Sprite.flipY = false;
            Sprite.flipX = false;
        }
        if (move.x < 0)
        {
            Sprite.flipX = true;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward) * Quaternion.AngleAxis(180, Vector3.forward);
            transform.rotation = rotation;
            transform.position = new Vector3(transform.position.x, transform.position.y, 180);
        }
    }

    private void onClickBullet()
    {
        timeCreate = timeCreate + Time.deltaTime;
        if (timeCreate >= John.atkSpeed)
        {
            timeCreate = 0;
            if (move.x > 0)
            {
                // Tính toán phương của đạn bằng cách tính góc giữa hai điểm và góc quay của khẩu súng
                Vector2 direction = (gunTip.position - gunPosition.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + gunPosition.localRotation.eulerAngles.z;

                // Tạo đối tượng đạn từ prefab và đặt vị trí của nó tại vị trí đuôi súng
                GameObject bullet = Instantiate(bulletPrefab, gunPosition.position, Quaternion.identity);
                // Xoay đạn theo phương của hai điểm và góc quay của khẩu súng
                bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);

                // Cài đặt vận tốc của đạn theo hướng vừa tính toán được
                Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                bulletRigidbody.velocity = direction * John.bulletSpeed;

            }
            if (move.x < 0)
            {
                // Tính toán phương của đạn bằng cách tính góc giữa hai điểm và góc quay của khẩu súng
                Vector2 direction = (gunPosition.position - gunTip.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + gunTip.localRotation.eulerAngles.z;

                // Tạo đối tượng đạn từ prefab và đặt vị trí của nó tại vị trí đuôi súng
                GameObject bullet = Instantiate(bulletPrefab, gunTip.position, Quaternion.identity);
                // Xoay đạn theo phương của hai điểm và góc quay của khẩu súng
                bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);

                // Cài đặt vận tốc của đạn theo hướng vừa tính toán được
                Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                bulletRigidbody.velocity = direction * John.bulletSpeed;
            }
        }
    }
}
