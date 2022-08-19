using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreController : MonoBehaviour
{
    private static TextMeshProUGUI _highScoreText;
    
    private static float highScoreSeconds;
    
    [SerializeField] public TimeController script;
    [SerializeField] public PlayerAtributes paScript;

    // Start is called before the first frame update
    void Start()
    {
        _highScoreText = GetComponent<TextMeshProUGUI>();
        if(highScoreSeconds > 0)
            _highScoreText.text = $"Best:{script.SecondsToTimerString(highScoreSeconds)}";
    }

    // Update is called once per frame
    void Update()
    {
        if(!paScript.IsAlive)
            highScoreSeconds = script.ElapsedTime > highScoreSeconds ? script.ElapsedTime : highScoreSeconds;
        
    }
}
