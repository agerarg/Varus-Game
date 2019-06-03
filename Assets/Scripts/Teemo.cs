using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("golpeo");
        if (collision.gameObject.tag == "VarusShot")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
