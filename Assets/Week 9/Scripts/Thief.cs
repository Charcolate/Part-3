using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{

    public GameObject knifePrefab;
    public GameObject knifePrefab2;
    public Transform spawnpoint;
    public Transform spawnpoint2;
    public float dashSpeed = 5f;

    protected override void Attack()
    {
        base.Attack();
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePosition - transform.position).normalized;
        Vector2 moveTowards = new Vector2(direction.x, direction.y) * dashSpeed * Time.deltaTime;
        destination = mousePosition;
        Instantiate(knifePrefab, spawnpoint.position, spawnpoint.rotation);
        Instantiate(knifePrefab2,spawnpoint2.position, spawnpoint2.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
