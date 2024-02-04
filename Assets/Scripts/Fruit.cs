using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public ParticleSystem explosion;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(7f, 10f));
        rb.angularVelocity = Random.Range(-360f, 360f);
    }

    void Update()
    {
        if (transform.position.y <= -4)
        {
            Miss();
        }
    }
    void Miss()
    {
        Destroy(gameObject);
    }

    public void Slice()
    {
        var particles = Instantiate(explosion);
        particles.transform.position = transform.position;

        Destroy(gameObject);
    }
}