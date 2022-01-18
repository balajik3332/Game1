using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 pos;

    private void Update()
    {
        pos = transform.position;
        pos.x += 1 * speed * Time.deltaTime;
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log(other);
            Destroy(gameObject);
        }
    }
}
