using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public int id;
    // green 67E263 red E65956 yellow E8E679 blue 6D81E6
    public Color color;
    private Color green_color = new Color(103f / 255f, 226f / 255f, 99f / 255f);
    private Color red_color = new Color(230f / 255f, 89f / 255f, 86f / 255f);
    private Color yellow_color = new Color(232f / 255f, 230f / 255f, 120f / 255f);
    private Color blue_color = new Color(109f / 255f, 128f / 255f, 230f / 255f);

    public Image top_image;
    public TextMeshProUGUI text;

    void Start()
    {
        int num = id % 4;
        switch (num)
        {
            case 0: color = green_color; break;
            case 1: color = red_color; break;
            case 2: color = yellow_color; break;
            case 3: color = blue_color; break;
        }
        top_image.color = color;

        text.text = (id + 1).ToString();
    }

    void Update()
    {

    }
}
