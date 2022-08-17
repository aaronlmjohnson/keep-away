using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 4f;

    private Rigidbody2D rb;

    public Transform player;
    Vector2 moveDirection;

    private void Awake(){
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Start(){
        //target = GameObject.Find("Player").transform; // returns Transform of Player
    }

    // Update is called once per frame
    void Update()
    {
        if(player){
            Vector3 direction = (player.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
        
    }

    void FixedUpdate(){
        // rb.MovePosition();
        if(player){
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

        // rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
}
