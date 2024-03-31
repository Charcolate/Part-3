using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupcake : food
{
    protected override void Start()
    {
        base.Start();
        StartCoroutine(FloatFood(3));
    }

    protected override IEnumerator FloatFood(float delay = 3)
    {
        return base.FloatFood(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
