using TMPro;
using UnityEngine;

public class DifficultChanger : MonoBehaviour
{
    [SerializeField] DifficultManagerSo data;
    private float baseCooldownDifficultMulty;
    private float cooldownDifficultMulty = 0f;
    private float difficultSpawnMulty;
    private float difficultSpeedMulty;

    private float maxSpawnTime;
    private float minSpawnTime;

    private void Start()
    {
        baseCooldownDifficultMulty = data.baseCooldownDifficultMulty;
        difficultSpawnMulty = data.difficultSpawnMulty;
        difficultSpeedMulty = data.difficultSpeedMulty;
    }

    private void Update()
    {
        cooldownDifficultMulty -= Time.deltaTime;

        if (cooldownDifficultMulty < 0) 
        {
            DifficultUp();
        }
    }

    private void DifficultUp() 
    {
        cooldownDifficultMulty += baseCooldownDifficultMulty;
        if (DataGameManager.actualMaxSpawnTime > data.maxMaxdifficultSpawnMulty) 
        {
            DataGameManager.actualMaxSpawnTime -= (float)difficultSpawnMulty;
        }

        if (DataGameManager.actualMinSpawnTime > data.maxMinDifficultSpawnMulty)
        {
            DataGameManager.actualMinSpawnTime -= (float)difficultSpawnMulty;
        }
        DataGameManager.actualSpikeSpeed -= (float)difficultSpeedMulty;
    }

}
