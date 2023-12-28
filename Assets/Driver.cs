using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //SerializeField allows us to access variable in Unity
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float slowSpeed = 10f;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Speed Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boosting...");
        }
        if (other.tag == "Speed Bump")
        {
            moveSpeed = slowSpeed;
            Debug.Log("Road hazard!");
        }
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0); 
        transform.Rotate(0, 0, -steerAmount); 
    }
}
