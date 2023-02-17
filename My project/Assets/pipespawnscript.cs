using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnscript : MonoBehaviour
{
    public GameObject biggerpipe;
    public float spawnRate = 2; //how many seconds between spawns
    private float timer = 0; //number that counts up
    public float heightOffset = 3;




    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); //puts the pipe at the start instead of having to wait
    }

    // Update is called once per frame




    void Update()
    {
        if (timer < spawnRate) //asks if timer is less then spawnRate, if it is count timer up, if it isn't then. once it surpasses the timer it spawns a pillar and resets timer to 0
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
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(biggerpipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);

    }
}
