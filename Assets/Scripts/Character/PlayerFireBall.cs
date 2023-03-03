using UnityEngine;

public class PlayerFireBall : MonoBehaviour
{
    [SerializeField]
    private FloatingJoystick Joystick;

    public float rotationSpeed = 3f; // The speed at which the gun rotates
    public GameObject projectilePrefab; // The projectile prefab to be instantiated
    public float projectileSpeed = 3f; // The speed at which the projectile moves

    private float timeCreate;
    private void FixedUpdate()
    {
        float horizontalInput = Joystick.Horizontal;
        float verticalInput = Joystick.Vertical;

        Vector2 direction = new Vector2(horizontalInput, verticalInput);
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        timeCreate += Time.deltaTime;
        if(timeCreate >=2 && (int)timeCreate % 2 == 0)
        {
           timeCreate = 0;
           Shoot();
        }
        
      
        Debug.Log("TimeCearte: " );
    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.velocity = transform.right * projectileSpeed;
    }
}
