using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UIElements;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Camera mainCamera;
    private float movingSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mainCamera.transform.Translate(Vector3.down * Time.deltaTime * movingSpeed);
    }
}
