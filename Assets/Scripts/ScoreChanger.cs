using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private float score = 0;
    private void Start()
    {
        score = 0;
        DataGameManager.generalScore = score;
        scoreText.text = score.ToString("F0");
    }
    private void Update()
    {
        score += Time.deltaTime * 10;
        DataGameManager.generalScore = score;
        scoreText.text = score.ToString("F0");
    }
}
