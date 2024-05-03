using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text scoreText;
    public AudioClip chimeSound; // The chime sound effect
    private int score = 0;
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        UpdateScoreDisplay();
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 10;
            UpdateScoreDisplay();
            Destroy(other.gameObject);
            // Play the chime sound
            if (chimeSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(chimeSound);
            }
        }

        if (other.gameObject.CompareTag("end"))
        {
            score += 100;
            UpdateScoreDisplay();
        }
    }

    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

