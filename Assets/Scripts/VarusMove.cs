using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarusMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Vertical")
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.position += Movement * speed * Time.deltaTime;
    }
}
