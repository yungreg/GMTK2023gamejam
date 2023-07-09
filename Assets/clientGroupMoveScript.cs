using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clientGroupMoveScript : MonoBehaviour
{
    public float clientGroupMoveSpeed = 5;
    public float deathZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * clientGroupMoveSpeed) *Time.deltaTime;
        
        if (transform.position.x < deathZone)
        {
            Debug.Log("clientGroup deleted");
            Destroy(gameObject);
        }
    }
}
