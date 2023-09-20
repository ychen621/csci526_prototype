using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    //Private variables
    private SpriteRenderer sr;
    public GameObject yellow;
    public GameObject red;

    // Start is called before the first frame update
    void Start()
    {
        //yellow = GameObject.FindGameObjectWithTag("portal");
        //red = GameObject.FindGameObjectWithTag("portal_door_2");
        sr = GetComponent<SpriteRenderer>();
        yellow.gameObject.SetActive(false);
        red.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collcted();
            yellow.gameObject.SetActive(true);
            red.gameObject.SetActive(true);
        }
    }

    private void collcted()
    {
        sr.enabled = false;
    }
}
