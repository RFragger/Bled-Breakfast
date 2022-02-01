using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMngr : MonoBehaviour
{

    public Slider meter;
    public float bloodLevels;
    public float currentMeter;
    public float bloodDrain;
    public bool collected;
    public float Blood;

    // Start is called before the first frame update
    void Start()
    {
        Cain.GM = this;
        bloodLevels = 100;
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
        }
    }
}
