using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; //sends reference to change velocity etc to rigidbody2d the physics thing, make sure to drag and drop in unity too
    // Start is called before the first frame update
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;



    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) //if input is spacebar
        {
            myRigidbody.velocity = Vector2.up * flapStrength; //shorthand for (0,1) to send bird flying up in sky, doing public flapstrength earlier lets us change the constant value in unity
        }
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
