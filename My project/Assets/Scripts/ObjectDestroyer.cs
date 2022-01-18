using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField]
    float timeOut = 45.0f;

    // Start is called before the first frame update
    void Awake()
    {
        Invoke("DestroyObject", timeOut);
    }

    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
