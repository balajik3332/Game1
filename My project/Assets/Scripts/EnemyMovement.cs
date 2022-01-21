using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Vector3 pos;
    int dir = -1;
    int maxDownup = 8;
    [SerializeField]
    float reachPlayerSpeed = -1.5f;
    [SerializeField]
    float EnemySpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        // Debug.Log("enemy start"+pos);
    }

    // Update is called once per frame
     void Update()
    {
        // left or right
        pos.y += EnemySpeed * dir * Time.deltaTime;
        transform.position = pos;
        if (transform.position.y <= -maxDownup)
        {
            dir = 1;
            pos.x += reachPlayerSpeed; // go down only at the border
            transform.position = new Vector2( pos.x,-maxDownup);
        }

        else if (transform.position.y >=maxDownup)
        {
            dir = -1;
            pos.x += reachPlayerSpeed; // go down only at the border
            transform.position = new Vector2( pos.x,maxDownup);
        }
    }
}
