using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 10;  
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;  
        }
    }

    void spawnPipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float heightestpoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, heightestpoint), 0), transform.rotation);
    }
}
