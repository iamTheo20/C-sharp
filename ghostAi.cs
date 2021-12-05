using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostAi : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    private Transform player;
    public Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite )
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position,speed*Time.deltaTime);
        }
        
    }
}
