using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xMovement = Input.GetAxis("Horizontal");
        var yMovement = Input.GetAxis("Vertical");

        transform.position += new Vector3(xMovement, yMovement, 0) * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(-23, 10, -8);
        }

        if(collision.gameObject.tag == "Sunlight")
        {
            transform.position = new Vector3(-23, 10, -8);
        }
    }
}
