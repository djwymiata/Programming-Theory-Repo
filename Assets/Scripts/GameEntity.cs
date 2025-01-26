// Unity Space Shooter Game Demonstrating OOP Principles

using UnityEngine;

// Base class for all game objects
public abstract class GameEntity : MonoBehaviour
{
    public float Speed { get; protected set; }

    public virtual void Move()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
}