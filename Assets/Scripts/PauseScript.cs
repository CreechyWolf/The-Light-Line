using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject MenuCanvas;

    MouseLook lookScript;
    public GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        lookScript = MainCamera.GetComponent<MouseLook>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuCanvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            lookScript.mouseSensitivity = 0f;
        }
    }

    public void Resume()
    {
        MenuCanvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        lookScript.mouseSensitivity = 700f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Grid()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
