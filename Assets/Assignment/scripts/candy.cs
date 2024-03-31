using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candy : food
{

    protected override void Start()
    {
        base.Start();
        StartCoroutine(FloatFood(0)); 
    }

    protected override IEnumerator FloatFood(float delay = 0)
    {
        return base.FloatFood(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
