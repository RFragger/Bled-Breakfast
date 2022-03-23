using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseEnemy : MonoBehaviour
{
    public Transform Playertransform;
    public BoxCollider2D bloodbox;
    [SerializeField] Transform[] Points;
    [SerializeField] float speed;
    public bool found;

    int NextPointIndex;
    Transform NextPoint;
    // Start is called before the first frame update
    void Start()
    {
        NextPoint = Points[0];
        found = false;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        if (transform.position == NextPoint.position && found==true)
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


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.tag == "Player")
        {
            ChaseDown();
        }
    }
    public void ChaseDown()
    {
        found = true;
    }

}



