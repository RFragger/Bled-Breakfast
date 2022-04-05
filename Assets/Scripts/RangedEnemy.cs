using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : MonoBehaviour
{

    public GameObject barrel;
    public GameObject arrow;
    public float timer;
    public Vector2 enemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        timer = 3;
        enemyPosition = barrel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if(timer <= 0)
        {
            ShootArrow();
            timer = 3;
        }
    }

    public void ShootArrow()
    {
        Instantiate(arrow, barrel.transform.position, transform.rotation);
    }

}
