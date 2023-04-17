using System;
using UnityEngine;

public class Level4 : MonoBehaviour
{
    public bool UseGravity = false;
    private float _speed = 5;
    
    private void Start()
    {
        var componentRigidbody =  gameObject.GetComponent<Rigidbody>();
        componentRigidbody.useGravity = UseGravity;
    }

    private void Update()
    {
        
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition; 
    }
}