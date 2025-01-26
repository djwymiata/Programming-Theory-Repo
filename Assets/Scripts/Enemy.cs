using UnityEngine;

// INHERITANCE
public class Enemy : GameEntity
{
    private void Start()
    {
        Speed = 2f;
    }

    private void Update()
    {
        Move();
    }

    // POLIMORPHISM
    public override void Move()
    {
        base.Move();
        if (transform.position.y < -5f) // Destroy enemy if it goes out of bounds
        {
            Destroy(gameObject);
        }
    }
}