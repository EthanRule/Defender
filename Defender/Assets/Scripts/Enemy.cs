using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(0.0f, 0.0f, 0.0f);
    public float smoothTime = 0.5f; 
    public float speed = 10;
    Vector3 velocity;
    private float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        /*
        * Make the enemy move towards the starting spawn point
        */
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
    }

    public void takeDamage(float damage) {
        health -= damage;

        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
