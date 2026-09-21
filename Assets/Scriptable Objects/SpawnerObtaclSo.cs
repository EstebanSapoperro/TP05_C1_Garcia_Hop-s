using UnityEngine;
[CreateAssetMenu(fileName = "SpawnerData", menuName = "Game/Data/Spawner")]
public class SpawnerObtaclSo : ScriptableObject
{
    public float minHeigt = -4;
    public float maxHeigt = -2;
    public float lifeObtalcTime = 8;
    public float minSpawnTime = 2;
    public float maxSpawnTime = 4;
    
}
