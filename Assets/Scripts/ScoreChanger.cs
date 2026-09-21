using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private float score = 0;
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString("F0");
    }
    private void Update()
    {
        score += Time.deltaTime * 10;
        scoreText.text = score.ToString("F0");
    }
}
