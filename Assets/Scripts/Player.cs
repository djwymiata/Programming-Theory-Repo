using UnityEngine;

public class Player : GameEntity
{
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    private void Start()
    {
        Speed = 5f;
    }

    private void Update()
    {
        HandleMovement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical, 0);
        transform.Translate(direction * Speed * Time.deltaTime);
    }

    private void Shoot()
    {
        Instantiate(BulletPrefab, BulletSpawn.position, Quaternion.identity);
    }
}