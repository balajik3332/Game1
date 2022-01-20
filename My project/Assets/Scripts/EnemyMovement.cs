using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Vector3 pos;
    int dir = -1;
    [SerializeField]
    float down = -0.5f;
    [SerializeField]
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        Debug.Log("enemy start"+pos);
    }

    // Update is called once per frame
     void Update()
    {
        // left or right
        pos.y += speed * dir * Time.deltaTime;
        transform.position = pos;
        if (transform.position.y <= -8.11283f)
        {
            dir = 1;
            pos.x += down; // go down only at the border
            transform.position = new Vector2( pos.x,-8.11283f);
        }

        else if (transform.position.y >=7.970025f)
        {
            dir = -1;
            pos.x += down; // go down only at the border
            transform.position = new Vector2( pos.x,7.970025f);
        }
    }
}
