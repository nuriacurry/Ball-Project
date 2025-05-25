using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float duration = 0;
    private float elaspedTime = 0;
    private bool started = false;
    private bool running = false;
    public float Duration { set { if (!running) duration = value;}}
    public bool Finished {get {return started && !running;}}
    public bool isRunning {get {return running;}}

    // Update is called once per frame
    void Update()
    {

        if (running)
         {
            elaspedTime += Time.deltaTime;
            if (elaspedTime >= duration) 
            {
                running = false;
                elaspedTime = 0;
            }
         }
    }

    public void run() 
    {
        if (duration > 0)
        {
            started = true;
            running = true;
            elaspedTime = 0;
        }

    }
}