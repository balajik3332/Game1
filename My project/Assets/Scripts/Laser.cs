using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 15f;
    private Vector3 pos;

    private void Update()
    {
        transform.Translate(new Vector3(2f * speed * Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.tag);
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

