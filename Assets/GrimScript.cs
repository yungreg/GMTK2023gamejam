using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimScript : MonoBehaviour
{
    //this reference allow the Grim Reaper script compnent in Unity to be th to 
    public Rigidbody2D myRigidBody;
    public float moveStrength;
    public logicManager logic;
    public bool grimIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true && grimIsAlive ) 
        { 
            myRigidBody.velocity = Vector2.up * moveStrength; 
        }

        // move one frame right when right key pressed
        if (Input.GetKeyDown(KeyCode.D) == true && grimIsAlive) 
        {
            myRigidBody.velocity = Vector2.right * moveStrength;
        }

        // move left by moveStrength
        if (Input.GetKeyDown(KeyCode.A) == true && grimIsAlive)
        {
            myRigidBody.velocity = Vector2.left * moveStrength;
        }

        if (Input.GetKeyDown(KeyCode.S) == true && grimIsAlive)
        {
            myRigidBody.velocity = Vector2.down * moveStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        grimIsAlive = false;
    }
}
 