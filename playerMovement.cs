using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour{
    public float moveSpeed;
    public int health;
    public Rigidbody2D rb;
    Vector2 movement;

    void Start(){
        health = 3;
    }

    void Update(){
        MovementInput();

    }

    private void FixedUpdate() {
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput () {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }

    private void OnCollisionEnter2D(Collision2D other){
       
        if (other.gameObject.tag == "Ghost"){
            health=health-1;
            if(health == 0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
