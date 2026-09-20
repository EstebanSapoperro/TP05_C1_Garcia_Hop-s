using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Game/Data/Player")]
public class PlayerDataSo : ScriptableObject
{

        public float jumpForce = 10;
        public float originalGravityScale = 3;
        public float jumpGravityScale = 1f;
        public float rayCastLong = 2.2f;

        public KeyCode jumpKey;
    
}
