using System.Collections;
using System.Collections.Generic;
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

        Vector3 startPos = transform.position;
        float floatHeight = 0.1f;
        float floatSpeed = 1f;

        while (!isEating)
        {
            // Float up and down
            float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
            transform.position = new Vector3(startPos.x, newY, startPos.z);

            yield return null;
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("Food"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
