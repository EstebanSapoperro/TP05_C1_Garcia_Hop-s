using UnityEngine;

public class ObstaclSpawner : MonoBehaviour
{
    [SerializeField] SpawnerObtaclSo data;
    public GameObject obtaclPrefab;
    private Vector3 spawnPosition;
    private float minHeigt;
    private float maxHeigt;
    private float lifeObtalcTime;
    private float minSpawnTime;
    private float maxSpawnTime;
    private float coolDown = 0;

    void Start()
    {

        minHeigt = data.minHeigt;
        maxHeigt = data.maxHeigt;
        lifeObtalcTime = data.lifeObtalcTime;
        spawnPosition = new Vector3(11, Random.Range(minHeigt, maxHeigt), 0);
        minSpawnTime = data.minSpawnTime;
        maxSpawnTime = data.maxSpawnTime;
        coolDown = Random.Range(minSpawnTime, maxSpawnTime);

        DataGameManager.actualMaxHeigt = data.maxHeigt;
        DataGameManager.actualMinHeigt = data.minHeigt;
        DataGameManager.actualMaxSpawnTime = data.maxSpawnTime;
        DataGameManager.actualMinSpawnTime = data.minSpawnTime;

    }

    private void Update()
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
        coolDown = Random.Range(DataGameManager.actualMinSpawnTime, DataGameManager.actualMaxSpawnTime);
        GameObject o = Instantiate(obtaclPrefab ,spawnPosition, Quaternion.identity);
        Destroy(o, lifeObtalcTime);
    }
}
