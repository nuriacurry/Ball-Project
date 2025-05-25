using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimer : MonoBehaviour
{
    Timer timer;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 5.0f;
        timer.run();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            float elaspedTime = Time.time - startTime;
            Debug.Log($"Timer ran: {elaspedTime} seconds");
            timer.run();
            startTime = Time.time;
        }
        
    }
}