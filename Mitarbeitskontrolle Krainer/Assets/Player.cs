using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float Variable = 0.01f;

    
    void Update()
    {
        


            if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, Variable);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(0, 0, Variable * 2);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Variable, 0, 0);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(Variable * 2, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -Variable);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(0, 0, -Variable * 2);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-Variable, 0, 0);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(-Variable * 2, 0, 0);
            }
        }

        


    }
}
