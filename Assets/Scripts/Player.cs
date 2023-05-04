using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
[SerializeField] float Walkspeed = 5f;



    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
}
