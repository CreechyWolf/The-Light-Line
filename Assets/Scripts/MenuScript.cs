using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    LevelLoader levelScript;
    public GameObject LevelLoader;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        levelScript = LevelLoader.GetComponent<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        levelScript.LoadPreLevel1FromMenu();
    }

    public void LevelSelect()
    {
        levelScript.LoadNextLevel();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
