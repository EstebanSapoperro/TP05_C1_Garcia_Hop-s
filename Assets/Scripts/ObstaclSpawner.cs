using UnityEngine;

public class ObstaclSpawner : MonoBehaviour
{
    [SerializeField] private float baseMinSpawnTime = 2;
    [SerializeField] private float baseMaxSpawnTime = 4;
    public GameObject obtacl;

    private Vector3 spawnPosition;
    private float minHeigt;
    private float maxHeigt;
    private float lifeObtalcTime;
    private float minSpawnTime;
    private float maxSpawnTime;
    private float coolDown = 0;

    void Start()
    {
        minHeigt = -4;
        maxHeigt = -2;
        lifeObtalcTime = 8;
        spawnPosition = new Vector3(11, Random.Range(minHeigt, maxHeigt), 0);
        minSpawnTime = baseMinSpawnTime;
        maxSpawnTime = baseMaxSpawnTime;
        coolDown = Random.Range(minSpawnTime, maxSpawnTime);
    }

    private void FixedUpdate()
    {
        coolDown -= Time.deltaTime;
        if (coolDown < 0) 
        {
            SpawnObtacle();
        }
    }

    private void SpawnObtacle() 
    {
        spawnPosition = new Vector3(11, Random.Range(minHeigt, maxHeigt), 0);
        coolDown = Random.Range(minSpawnTime, maxSpawnTime);
        GameObject o = Instantiate(obtacl ,spawnPosition, Quaternion.identity);
        Destroy(o, lifeObtalcTime);
    }
}
