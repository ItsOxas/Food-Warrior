using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        rb.MovePosition(worldPos); 

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print(":)");
        var food = other.gameObject.GetComponent<Fruit>();
        food.Slice();
    }
}
