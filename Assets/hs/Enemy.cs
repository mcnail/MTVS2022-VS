using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5;

    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        dir = new Vector3(0, -1, 0);
        //dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        dir.Normalize();

        dir = dir * speed * Time.deltaTime;

        transform.position = transform.position + dir;
    }
}
