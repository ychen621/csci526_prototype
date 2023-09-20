using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAlongWithPlayer : MonoBehaviour
{

    //Private Variables
    private int currIndex = 0;

    public GameObject player;
    //Public Variables
    public Vector2[] setPoints;
    public float movingSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, setPoints[currIndex], movingSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, setPoints[currIndex]) < 0.02f)
        {
            currIndex++;
            if (currIndex >= setPoints.Length)
            {
                currIndex = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
       
        if (other.tag == "Player") 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.SetParent(null);
        }
    }
}
