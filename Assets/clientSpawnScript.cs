using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class clientSpawnScript : MonoBehaviour
{
    public GameObject clients;
    public float spawnRate = 2;
    private float timer = 0;
    public float originOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnclient(); // this makes sure on frame 1, clients start spawning
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnclient();
            timer = 0;
        }
    }

    void spawnclient()
    {
        float lowestPoint = transform.position.y - originOffset;
        float highestPoint = transform.position.y + originOffset;

        Instantiate(clients, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
