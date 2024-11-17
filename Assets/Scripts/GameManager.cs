using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject board;
    public Plane plane;

    private Cell[] cells;
    private int current_index;

    public float duration = 2f;
    private float move_timer = 0f;

    void Start()
    {
        cells = board.GetComponentsInChildren<Cell>();

        current_index = 0;

        plane.transform.position = cells[0].transform.position;
    }


    void Update()
    {
        move_timer += Time.deltaTime;

        if(move_timer >= duration)
        {
            move_timer = 0f;
            if(current_index < cells.Length - 1)
                current_index++;
        }

        plane.MovePlane(cells[current_index].transform.position);
    }
}
