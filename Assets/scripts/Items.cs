using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Items : MonoBehaviour
{

    public float bobSpeed = 2f;
    public float bobHeight = 0.1f;
    public float spinSpeed = 70f;

    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.Self);

        float newY = startPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight / 2;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}