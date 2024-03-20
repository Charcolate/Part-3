using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Thief : Villager
{

    public GameObject knifePrefab;
    public GameObject knifePrefab2;
    public Transform spawnpoint;
    public Transform spawnpoint2;
    public float dashspeed = 7f;
    Coroutine dashing;

    protected override void Attack()
    {
        if (dashing == null)
        {
            StopCoroutine(dashing);
            StopAllCoroutines();
        }
        dashing = StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;

        while (speed > 3)
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(knifePrefab, spawnpoint.position, spawnpoint.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(knifePrefab2, spawnpoint2.position, spawnpoint2.rotation);
       
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    public override string ToString()
    {
        return "Hi, I'm Bob!";
    }
}
