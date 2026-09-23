using UnityEngine;

[CreateAssetMenu(fileName = "DifficultData", menuName = "Game/Data/Difficult")]
public class DifficultManagerSo : ScriptableObject
{
    public float baseCooldownDifficultMulty = 10;
    public float difficultSpawnMulty = 0.2f;
    public float difficultSpeedMulty = 0.8f;
    public float maxMinDifficultSpawnMulty = 0.8f;
    public float maxMaxdifficultSpawnMulty = 1f;


}
