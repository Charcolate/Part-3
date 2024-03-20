using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    public Transform spawnpoint;

    Coroutine scalingCoroutine;
    int currentBuilding = 1;

    // Start is called before the first frame update
    void Start()
    {
        scalingCoroutine = StartCoroutine(ScaleBuildings());
    }

    IEnumerator ScaleBuildings()
    {
        Instantiate(building1, spawnpoint.position, spawnpoint.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(building2, spawnpoint.position, spawnpoint.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(building3, spawnpoint.position, spawnpoint.rotation);
        yield return new WaitForSeconds(0.5f);
    }
}
