using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgscroller2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime,0);

        if(transform.position.x < -36){
            transform.position = new Vector3(-12f, transform.position.y);
        }
        
    }
}
