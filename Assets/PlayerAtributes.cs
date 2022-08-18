using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtributes : MonoBehaviour
{
    private bool _isAlive = true;
    private float _maxHealth = 3;
    private float _currentHealth;

    public bool IsAlive {
        get => _isAlive;
        set => _isAlive = value;
    }

    public float MaxHealth {
        get=> _maxHealth;
        set => _maxHealth = value;
    }

    public float CurrentHealth {
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
