using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int Score { get; set; }

    private void Update()
    {
        scoreText.text = Score.ToString();
    }
}
