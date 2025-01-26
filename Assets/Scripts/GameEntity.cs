// Unity Space Shooter Game Demonstrating OOP Principles

using UnityEngine;

// Base class for all game objects
// ABSTRACTION
public abstract class GameEntity : MonoBehaviour
{
    // ENCAPSULATION
    public float Speed { get; protected set; }

    // POLIMORPHISM
    public virtual void Move()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
}