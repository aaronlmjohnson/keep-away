using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtributes : MonoBehaviour
{
    private bool _isAlive = true;

    public bool IsAlive {
        get => _isAlive;
        set => _isAlive = value;
    }

    void Start(){
        _isAlive = true;
    }
}
