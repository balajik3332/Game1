using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 pos;

    private void Update()
    {
       transform.Translate(new Vector3(2f*speed*Time.deltaTime,0,0));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}

