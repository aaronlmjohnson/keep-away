using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] public PlayerAtributes paScript;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Enemy"){
            KillPlayer();
        }
    }

    void KillPlayer(){
        Destroy(this.gameObject);
        paScript.IsAlive = false;
        RestartGame();

    }

    void RestartGame(){
       SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
