using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputKeyScript : MonoBehaviour
{
    public Slider RevealSlider;
    public Slider ResetSlider;

    public GameObject RevealUsed;
    public GameObject LightLine;

    private float KeyDownTimeQ;
    private float KeyDownTimeR;
    public float RequiredHoldTime = 1.5f;
    private int RevealCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //while q held
        if (Input.GetKey(KeyCode.Q) && RevealCounter != 1)
        {
            KeyDownTimeQ += Time.deltaTime;
            RevealSlider.value = KeyDownTimeQ;

            //if key held long enough, reveal
            if (KeyDownTimeQ >= RequiredHoldTime)
            {
                Debug.Log("reveal light line active");
                LightLine.SetActive(true);
                StartCoroutine(LineReveal());

                KeyDownTimeQ = 0f;
                RevealCounter = 1;
                Debug.Log("hold reset and deactive");

                RevealUsed.SetActive(true);
                RevealSlider.gameObject.SetActive(false);
            }
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (KeyDownTimeQ < RequiredHoldTime)
            {
                KeyDownTimeQ = 0f;
                RevealSlider.value = 0f;
            }
        }


        if (Input.GetKey(KeyCode.R))
        {
            KeyDownTimeR += Time.deltaTime;
            ResetSlider.value = KeyDownTimeR;

            //if key held long enough, reveal
            if (KeyDownTimeR >= RequiredHoldTime)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            if (KeyDownTimeR < RequiredHoldTime)
            {
                KeyDownTimeR = 0f;
                ResetSlider.value = 0f;
            }
        }
    }
    IEnumerator LineReveal()
    {
        yield return new WaitForSeconds(3f);
        LightLine.SetActive(false);
    }
}
