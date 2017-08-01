using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    [SerializeField]
    private GameObject enemy;

    private readonly float _spawnTime = 0.12f;

	private void Start () {
        InvokeRepeating("Spawn", _spawnTime, _spawnTime);
    }

    private void Spawn()
    {
        var spawnPointX = Random.Range(-10, 10);
        var spawnPointY = 32;
        var spawnPointZ = 10;
        var spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}

internal class GameObject
{
}
