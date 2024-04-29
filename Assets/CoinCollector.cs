using UnityEngine;
using TMPro; // Include this for TextMeshPro support

public class CoinCollector : MonoBehaviour
{
    public TMP_Text scoreText;   // Reference to the TextMeshPro UI element that displays the score
    private int score = 0;       // The player's score

    void Start()
    {
        UpdateScoreDisplay(); // Initialize the score display
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with a coin
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 10; // Increment the score by 10
            UpdateScoreDisplay(); // Update the UI display of the score
            Destroy(other.gameObject); // Optionally destroy the coin object to simulate collection
        }

        if (other.gameObject.CompareTag("end"))
        {
            score += 100; // Increment the score by 10
            UpdateScoreDisplay(); // Update the UI display of the score
        }
    }

    // Method to update the score display in the UI
    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
