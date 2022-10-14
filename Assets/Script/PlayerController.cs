using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float horizontalIput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {



        // keep the players in bounds 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //for the right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalIput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalIput * Time.deltaTime * speed);

    }
}
