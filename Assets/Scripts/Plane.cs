using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
    public int id;
    public int group;

    public Color color;
    // green 67E263 red E65956 yellow E8E679 blue 6D81E6
    private Color green_color = new Color(103f / 255f, 226f / 255f, 99f / 255f);
    private Color red_color = new Color(230f / 255f, 89f / 255f, 86f / 255f);
    private Color yellow_color = new Color(232f / 255f, 230f / 255f, 120f / 255f);
    private Color blue_color = new Color(109f / 255f, 128f / 255f, 230f / 255f);

    public Image top_image;
    public float move_speed;

    void Start()
    {
        //int num = id % 4;
        //switch (num)
        //{
        //    case 0: color = green_color; break;
        //    case 1: color = red_color; break;
        //    case 2: color = yellow_color; break;
        //    case 3: color = blue_color; break;
        //}
        top_image.color = color;
    }

    void Update()
    {

    }

    public void MovePlane(Vector3 dst)
    {
        transform.position = Vector2.Lerp(transform.position, dst, Time.deltaTime * move_speed);
    }
}