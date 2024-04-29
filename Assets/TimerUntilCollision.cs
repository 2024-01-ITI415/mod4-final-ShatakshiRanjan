using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class TimerUntilCollision : MonoBehaviour
{
    public TMP_Text timerText; // Change to TMP_Text for TextMeshPro
    public TMP_Text winText;
    public GameObject winBlock;
    private float startTime;
    private bool isRunning = true;

    void Start()
    {
        // Start the timer
        startTime = Time.time;
        winText.gameObject.SetActive(false);
        winBlock.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isRunning)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((int)(t * 100) % 100).ToString("00");

            // Update the timer text using TextMeshPro
            if (timerText != null)
            {
                timerText.text = "Time:" + minutes + ":" + seconds + ":" + milliseconds;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Stop the timer
            isRunning = false;
            winText.gameObject.SetActive(true);
            winText.text = "You found the treasure!";
            winBlock.gameObject.SetActive(true);

        }
    }
}
