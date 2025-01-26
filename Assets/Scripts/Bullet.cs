using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;

    private void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);

        if (transform.position.y > 50f) // Destroy bullet if it goes out of bounds
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destroy the enemy
            Destroy(gameObject);          // Destroy the bullet
        }
    }
}
