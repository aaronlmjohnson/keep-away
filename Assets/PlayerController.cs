using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    //public StatusBar healthBar;

    //public Rigidbody2D rb;

    Vector2 move;
    void Start(){
        //healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(move * speed * Time.deltaTime);
    }

    // void FixedUpdate() {
    //     rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    // }
}
