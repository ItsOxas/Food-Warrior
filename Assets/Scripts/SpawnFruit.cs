using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public List<Object> fruits;
    public Object bomb;

    void Start()
    {
        GetComponent<Rigidbody2D>();
        InvokeRepeating("spawnFruit", 1, 1);
    }

    void Update()
    {
    }
    void spawnFruit()
    {
        var prefab = Random.Range(0, 100) < 80 ? fruits[0] : bomb;     
        
        var rndPos = new Vector2(Random.Range(-3f, 3f), -3);
        Instantiate(prefab, rndPos, Quaternion.identity);
    }
}