using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Load scene2
            SceneManager.LoadScene("Scene2");
        }
    }

}
