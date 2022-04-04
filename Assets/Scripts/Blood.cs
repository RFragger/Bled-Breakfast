using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blood : MonoBehaviour
{
    public GameObject bloodDrop;
    public SpriteRenderer bloodRend;
    public CircleCollider2D bloodCollider;
    public AudioSource bloodSlurp;
   

    // Start is called before the first frame update
    void Start()
    {
        bloodCollider.enabled = true;
        bloodRend.enabled = true;

        //bloodLevels = 100;
        //collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        

       
    }

    //public void BloodCollected()
    //{
        
       // bloodCollider.enabled = false;
       // bloodRend.enabled = false;
        
        //if (collected == true)
       // {
       //     bloodLevels = bloodLevels + 10;
       // }
       // collected = false;

    //}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "Player")
        {
            Cain.GM.bloodLevels += 25;
            Destroy(gameObject);
            bloodSlurp.Play();

            //collected = true;
            //BloodCollected();
            //Debug.Log("Collected Blood");
        }
    }

}
