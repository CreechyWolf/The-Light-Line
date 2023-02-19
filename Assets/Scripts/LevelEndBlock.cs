using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndBlock : MonoBehaviour
{
    public GameObject Player;

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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            levelScript.LoadNextLevel();
        }
    }
}
