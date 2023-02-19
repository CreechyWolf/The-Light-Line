using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreLevel1FromMenu()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }

    public void LoadPreLevel2()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));
    }

    public void LoadPreLevel3()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 5));
    }

    public void LoadMenuFromLast()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 8));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}

