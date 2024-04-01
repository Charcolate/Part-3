using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEditor;
using UnityEngine;

public class food : MonoBehaviour
{
    public static bool isEating = false; //static variable to check if the players are eating the food

    public static void StartEating() //static function
    {
        isEating = true;
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        StartCoroutine(FloatFood());
    }

    protected virtual IEnumerator FloatFood(float delay = 0)
    {
        yield return new WaitForSeconds(delay);

        Vector3 startPosition = transform.position;
        float floatHeight = 0.1f;
        float floatSpeed = 1f;

        while (!isEating)
        {
            float newHeight = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
            transform.position = new Vector3(startPosition.x, newHeight, startPosition.z);

            yield return null;
        }
    }

    protected virtual void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartEating();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
