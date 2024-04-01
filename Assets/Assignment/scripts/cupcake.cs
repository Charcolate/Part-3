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

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        eat();
    }

    void eat()
    {
        Debug.Log("A treat at the end of the day.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
