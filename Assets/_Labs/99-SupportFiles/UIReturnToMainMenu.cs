using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIReturnToMainMenu : MonoBehaviour
{

    public GameObject returnMenu;
    //public GameObject fpsController;


    public void Awake()
    {
       
        //returnMenu.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Scene1");
    }


    // Update is called once per frame
    public void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0)))
        {
            GoToGame();

        }
        if ((Input.GetKeyDown(KeyCode.Escape)))
        {
            ReturnToMainMenu();
        }
    }
}
