using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SizeScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Maze;
    public GameObject zone;

    private float lastX;
    private float lastZ;

    private Vector3 Size;
    private float correctIncrement = 0.001f;
    private float wrongIncrement = 0.005f;

    public Slider sizeSlider;
    public TextMeshProUGUI sizeText;
    float size = 00f;
    public float maxSize = 0f;

    // Start is called before the first frame update
    void Start()
    {
        lastX = Player.transform.position.x;
        lastZ = Player.transform.position.z;

        Size.y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        string sizeTime = string.Format("{0}", Size.y);
        size = Size.y;

        sizeText.text = sizeTime;
        sizeSlider.value = size;

        if (Size.y >= maxSize)
        {
            Maze.SetActive(false);
        }
    }

    void Grow()
    {
        Debug.Log("grow active");
        Size.y = Size.y + correctIncrement;
        Player.transform.localScale = Size;
    }

    void OverGrow()
    {
        Debug.Log("overgrow active!");
        Size.y = Size.y + wrongIncrement;
        Player.transform.localScale = Size;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject != zone)
        {
            zone.SetActive(false);
        }

        if (lastX != Player.transform.position.x || lastZ != Player.transform.position.z)
        {
            if (!zone.activeSelf)
            {
                Grow();
            }
            else
            {
                OverGrow();
            }
        }
        lastX = Player.transform.position.x;
        lastZ = Player.transform.position.z;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject != zone)
        {
            zone.SetActive(true);
        }
    }
}
