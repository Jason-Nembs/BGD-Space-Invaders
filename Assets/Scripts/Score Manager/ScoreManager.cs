using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton instance for global access

    private int score = 0; // The player's current score

    private void Awake()
    {
        // Ensure only one instance of the ScoreManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object across scene loads
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate ScoreManagers
        }
    }

    // Function to add points to the score
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score); // Print the score to the console
    }

    // Function to retrieve the current score (optional)
    public int GetScore()
    {
        return score;
    }
}
