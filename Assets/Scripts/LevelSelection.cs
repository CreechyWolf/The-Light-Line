using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    LevelLoader levelScript;
    public GameObject LevelLoader;

    // Start is called before the first frame update
    void Start()
    {
        levelScript = LevelLoader.GetComponent<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        levelScript.LoadNextLevel();
    }

    public void Level2()
    {
        levelScript.LoadPreLevel2();
    }

    public void Level3()
    {
        levelScript.LoadPreLevel3();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
