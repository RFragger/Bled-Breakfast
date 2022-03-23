using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightObstacle : MonoBehaviour
{

    public float lightStat;
    public float timer;
    public SpriteRenderer lightBox;
    public EdgeCollider2D lightCollid;
    public bool Fliptime;

    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        lightBox.enabled = true;
        lightCollid.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if(timer <= 0)
        {
            FlipSwitch();
        }
    }
    public void FlipSwitch()
    {
        
         if(lightBox.enabled == true)
         {
            lightBox.enabled = false;
            lightCollid.enabled = false;
            timer = 5;
         } else if(lightBox.enabled == false)
        {
            lightBox.enabled = true;
            lightCollid.enabled = true;
            timer = 5;
        }
    }


}
