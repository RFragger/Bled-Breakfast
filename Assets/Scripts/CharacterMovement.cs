using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    public float speed;

    public AudioSource stabbed;
    public AudioSource arrowHit;
    
    // Start is called before the first frame update
    void Start()
    {
        //GameMngr.GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameMngr.GameOver) return;
        var xMovement = Input.GetAxis("Horizontal");
        var yMovement = Input.GetAxis("Vertical");

        transform.position += new Vector3(xMovement, yMovement, 0) * Time.deltaTime * speed;

        float rot = transform.rotation.eulerAngles.z; 
        //Right
        if (xMovement > 0 && yMovement == 0) rot = -90;
        //Right-Diagonal-Up
        else if (xMovement > 0 && yMovement > 0) rot = -45;
        //Left
        if (xMovement < 0 && yMovement == 0) rot = 90;
        //Left-Diagonal-Up
        else if (xMovement < 0 && yMovement > 0) rot = 45;
        //Up
        if (xMovement == 0 && yMovement > 0) rot = 360;
        //Down
        else if (xMovement == 0 && yMovement < 0) rot = -180;
        //Left-Diagonal-Down
        if (xMovement < 0 && yMovement < 0) rot = 135;
        //Right-Diagonal-Down
        else if (xMovement > 0 && yMovement < 0) rot = -135;

        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(-23, 10, -8);
            stabbed.Play();
        }

        if(collision.gameObject.tag == "Sunlight")
        {
            transform.position = new Vector3(-23, 10, -8);
        }

        if(collision.gameObject.tag == "Arrow")
        {
            transform.position = new Vector3(-23, 10, -8);
            arrowHit.Play();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Exit")
        {
            //GameMngr.GameOver = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
