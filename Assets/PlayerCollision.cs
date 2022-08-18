using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] public PlayerAtributes paScript;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Enemy"){
            paScript.TakeDamage(1);
        }
    }

    void KillPlayer(){
        Destroy(this.gameObject);
        RestartGame();
    }

    void RestartGame(){
       SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    void Update(){
        if(!paScript.IsAlive) KillPlayer();
    }
}
