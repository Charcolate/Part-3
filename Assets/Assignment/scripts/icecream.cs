using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icecream : food
{
    protected override void Start()
    {
        base.Start();
        StartCoroutine(FloatFood(2));
    }

    protected override IEnumerator FloatFood(float delay = 2)
    {
        return base.FloatFood(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
