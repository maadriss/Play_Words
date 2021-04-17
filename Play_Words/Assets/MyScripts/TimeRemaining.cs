using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour
{
    public GameObject panel;
    public float minute;
    public float second;
    public Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        second = 5;
        minute = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.gameObject.activeSelf)
        {
            second -= Time.deltaTime;
            if (second < 0) { minute--; second = 59; }
            if (minute == 0) { minute = 3; second = 59; }
        }
        timeText.text = minute + ":" + (int)second;
    }

  
}