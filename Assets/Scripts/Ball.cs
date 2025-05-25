using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Collections.Specialized;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int count = 0;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        Vector3 position = transform.position;
        position.x = 2;
        transform.position = position;
        Vector3 scale = transform.localScale;
        scale.x = 2;
        scale.y = 2;
        transform.localScale = scale;
        rb2d.AddForce(new Vector2(Random.Range(3,5), Random.Range(3,5)), ForceMode2D.Impulse);
    
        Debug.Log("This is the first script");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Collision detection for bouncing ball
    void OnCollisionEnter2D(Collision2D col)
    {
        count++;
        Debug.Log("Bang " + count);

        // Task 1: Stop playing the game when balls collide 20 times
        if (count == 20) 
        {
            Debug.Log("Game ending after 20 collisions!");
            
            // Task 2: Destroy the ball object and print message
            Debug.Log("Ball object destroyed after 20 collisions");
            Destroy(gameObject);
            
            // Stop the game in Unity Editor
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}