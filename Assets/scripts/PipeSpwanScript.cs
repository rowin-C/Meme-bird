using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwanScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spwanPipe();


    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;

        }
    }
    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0),transform.rotation);

    }
}
