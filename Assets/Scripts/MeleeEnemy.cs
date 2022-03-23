using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] float speed;

    int NextPointIndex;
    Transform NextPoint;
    // Start is called before the first frame update
    void Start()
    {
        NextPoint = Points[0];
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        if (transform.position == NextPoint.position)
        {
            NextPointIndex++;
            if (NextPointIndex >= Points.Length)
            {
                NextPointIndex = 0;
            }
            NextPoint = Points[NextPointIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPoint.position, speed * Time.deltaTime);
        }
    }
}