using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject board;

    private Cell[] cells;
    private Plane[] planes;
    private Plane current_plane;
    private int plane_index;

    public float duration = 2f;
    private float move_timer = 0f;

    private int steps = 0;
    private int move_count = 0;

    void Start()
    {
        cells = board.GetComponentsInChildren<Cell>();
        planes = board.GetComponentsInChildren<Plane>();

        plane_index = 0;
        current_plane = planes[plane_index];



        steps = Random.Range(1, 7);
    }


    void Update()
    {
        move_timer += Time.deltaTime;

        if (move_timer >= duration)
        {
            move_timer = 0f;

            //if (current_plane.cell_index < cells.Length - 1)
            //    current_plane.cell_index++;

        }
        Move();
    }

    private void Move()
    {
        if (current_plane.cell_index + steps < cells.Length)
        {
            bool reached = current_plane.MovePlane(cells[current_plane.cell_index]);
            if(reached)
            {
                reached = false;
                current_plane.cell_index++;
                move_count++;
                if(move_count >= steps)
                {
                    move_count = 0;
                    steps = Random.Range(1, 7);
                    plane_index++;
                    plane_index %= planes.Length;
                    current_plane = planes[plane_index];
                }
            }
        }
    }
}
