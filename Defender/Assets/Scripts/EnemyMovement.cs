using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
public Vector3 targetPosition = new Vector3(0.0f, 0.0f, 0.0f);
public float smoothTime = 0.5f; 
public float speed = 10;
Vector3 velocity;
void Start()
{

}
void Update()
{
    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
}
}
