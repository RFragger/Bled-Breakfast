using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMngr : MonoBehaviour
{

    public Slider meter;
    public float bloodLevels;
    public float currentMeter;
    public float bloodDrain;
    public bool collected;
    public float Blood;
    public bool Dead;
    public Button Restartbutton;
    public Image ButtonImage;
    public Text ButtonText;
    

    // Start is called before the first frame update
    void Start()
    {
        Dead = false;
        Cain.GM = this;
        bloodLevels = 100;
        Restartbutton.enabled = false;
        ButtonImage.enabled = false;
        ButtonText.enabled = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        currentMeter = bloodLevels;
        meter.value = currentMeter;
        bloodLevels = bloodLevels - Time.deltaTime * bloodDrain;
        if (bloodLevels >= 100)
        {
            bloodLevels = 100;
        }
        if (bloodLevels <= 0)
        {
            bloodLevels = 0;
            Dead = true;

        }

        if (Dead == true)
        {
            Restartbutton.enabled = true;
            ButtonImage.enabled = true;
            ButtonText.enabled = true;
        }

       

    }

    public void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Clicked(string levelName)
    {
        Debug.Log("CLICKED ME: " + levelName);
        SceneManager.LoadScene(levelName);
    }
}
