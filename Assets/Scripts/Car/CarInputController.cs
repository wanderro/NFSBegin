using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    
    void Update()
    {
        var position = gameObject.transform.position;
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }


        
        transform.position = position;
    }
}
