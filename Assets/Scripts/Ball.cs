using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
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
}
