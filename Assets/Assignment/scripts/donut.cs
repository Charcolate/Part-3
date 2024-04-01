using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donut : food
{

    protected override void Start()
    {
        base.Start();
        StartCoroutine(FloatFood(1));
    }

    protected override IEnumerator FloatFood(float delay = 1)
    {
        return base.FloatFood(delay);
    }

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        bite();
    }

    void bite()
    {
        Debug.Log("It's fluffy!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
