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
    float elapsedTime = 0f;

    Coroutine scalingCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        scalingCoroutine = StartCoroutine(ScaleBuildings());
    }

    IEnumerator ScaleBuildings()
    {
        GameObject instantiatedBuilding1 = Instantiate(building1, spawnpoint.position, spawnpoint.rotation);
        yield return StartCoroutine(IncreaseScale(instantiatedBuilding1, 1.5f, 1.0f));
        yield return new WaitForSeconds(0.5f);

        GameObject instantiatedBuilding2 = Instantiate(building2, spawnpoint.position, spawnpoint.rotation);
        yield return StartCoroutine(IncreaseScale(instantiatedBuilding2, 1.5f, 1.0f));
        yield return new WaitForSeconds(0.5f);

        GameObject instantiatedBuilding3 = Instantiate(building3, spawnpoint.position, spawnpoint.rotation);
        yield return StartCoroutine(IncreaseScale(instantiatedBuilding3, 1.5f, 1.0f));
    }

    IEnumerator IncreaseScale(GameObject building, float targetScaleFactor, float duration)
    {
        Vector3 initialScale = building.transform.localScale;
        Vector3 targetScale = new Vector3(initialScale.x * targetScaleFactor, initialScale.y * targetScaleFactor, initialScale.z);

        while (elapsedTime < duration)
        {
            building.transform.localScale = Vector3.Lerp(initialScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        building.transform.localScale = targetScale;
    }
}
