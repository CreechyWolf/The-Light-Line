using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastLevelBlock : MonoBehaviour
{
    LevelLoader levelScript;
    public GameObject LevelLoader;

    public Slider StartSlider;

    private float KeyDownTimeE;
    public float RequiredHoldTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        levelScript = LevelLoader.GetComponent<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            KeyDownTimeE += Time.deltaTime;
            StartSlider.value = KeyDownTimeE;

            //if key held long enough, reveal
            if (KeyDownTimeE >= RequiredHoldTime)
            {
                levelScript.LoadMenuFromLast();
            }
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            if (KeyDownTimeE < RequiredHoldTime)
            {
                KeyDownTimeE = 0f;
                StartSlider.value = 0f;
            }
        }
    }
}
