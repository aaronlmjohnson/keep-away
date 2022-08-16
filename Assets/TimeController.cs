using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimeController : MonoBehaviour
{
    private TextMeshProUGUI _timerText;
    private static float _elapsedTime = 0; // make public so high scores can access

    public float ElapsedTime {
        get { return _elapsedTime;}
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        _elapsedTime = 0;
        _timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer(){
        _elapsedTime += Time.deltaTime;
        _timerText.text = SecondsToTimerString(_elapsedTime);
    }

     public string SecondsToTimerString(float seconds){
        
        TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
        return String.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
    }
}
