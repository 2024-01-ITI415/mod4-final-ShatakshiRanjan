using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    private Animator _doorAnim;
    public AudioClip doorSound; // The door opening/closing sound effect
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        _doorAnim = GetComponent<Animator>();
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Add AudioSource component if not already attached
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("Close");
            // Play the door closing sound
            if (doorSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(doorSound);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("Open");
            // Play the door opening sound
            if (doorSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(doorSound);
            }
        }
    }
}
