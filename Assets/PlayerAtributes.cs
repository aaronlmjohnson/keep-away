using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtributes : MonoBehaviour
{
    private bool _isAlive = true;
    private int _maxHealth = 3;
    private int _currentHealth;

    public bool IsAlive {
        get => _isAlive;
        set => _isAlive = value;
    }

    public int MaxHealth {
        get=> _maxHealth;
        set => _maxHealth = value;
    }

    public int CurrentHealth {
        get=> _currentHealth;
        set => _currentHealth = value;
    }

    public void TakeDamage(int amount){
        _currentHealth -= amount;
        Debug.Log($"Health Remaining:{_currentHealth}");
        if(CurrentHealth < 1) _isAlive = false;
    }

    void Start(){
        _isAlive = true;
        _currentHealth = _maxHealth;
    }
}
