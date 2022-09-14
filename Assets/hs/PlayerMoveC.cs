using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveC : MonoBehaviour
{
    private Vector3 dir; //Graph Variable
    public float speed = 5; //Object Variable
    // Start is called before the first frame update
    void Start()    {
        //h = Input.GetAxis("Horizontal"); //¿¡·¯
    }

    // Update is called once per frame
    void Update()
    {
        float h; //flow variable
        float v;
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, v, 0);
        //dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        dir.Normalize();

        dir = dir * speed * Time.deltaTime;

        transform.position = transform.position + dir;
    }
}
