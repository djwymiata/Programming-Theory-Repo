using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform[] SpawnPoints;
    public float SpawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), SpawnInterval, SpawnInterval);
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(EnemyPrefab, SpawnPoints[randomIndex].position, Quaternion.identity);
    }
}
