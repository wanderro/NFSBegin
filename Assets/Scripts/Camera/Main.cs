using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private CarInputController _car;
    
    [SerializeField]
    private Vector3 _offset;

    private void Start()
    {
        _car = FindObjectOfType<CarInputController>();
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
