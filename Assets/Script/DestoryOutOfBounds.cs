using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private float topBound = 30;
    private float lowerBound = -6;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
