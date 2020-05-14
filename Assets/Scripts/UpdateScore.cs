using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.Score++;
    }
}
