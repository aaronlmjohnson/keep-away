using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtributes : MonoBehaviour
{
    private bool _isAlive = true;
    private bool _isImmune = false;
    private float _maxHealth = 3;
    private float _currentHealth;
    private float _immunityTimer;
    private const int IMMUNITY_TIMER_DURATION = 2;

    public bool IsAlive {
        get => _isAlive;
        set => _isAlive = value;
    }

    public float MaxHealth {
        get => _maxHealth;
        set => _maxHealth = value;
    }

    public bool IsImmune {
        get => _isImmune;
        set => _isImmune = value;
    }

    public float CurrentHealth {
        get=> _currentHealth;
        set => _currentHealth = value;
    }

    public void TakeDamage(int amount){
        if(_isImmune) return;
        _currentHealth -= amount;
        if(CurrentHealth < 1) _isAlive = false;
        _isImmune = true;
    }

    void Start(){
        _isAlive = true;
        _currentHealth = _maxHealth;
    }

    void Update(){
        if(!_isImmune) _immunityTimer = 0;
        if(_immunityTimer >= IMMUNITY_TIMER_DURATION) _isImmune = false;
        else _immunityTimer += Time.fixedDeltaTime;
    }
}
