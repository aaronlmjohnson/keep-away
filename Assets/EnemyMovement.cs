using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 4f;

    public Rigidbody2D rb;

    Transform target;
    Vector2 moveDirection;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        target = GameObject.Find("Player").transform; // returns Transform of Player
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
        
    }

    void FixedUpdate(){
        // rb.MovePosition();
        if(target){
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

        // rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
}
