using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 pos;
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    GameObject Capsule;
    GameObject newCapsule;
    int dir = 1; //-1
    [SerializeField]
    public AudioClip laserSFX;
    // AudioSource _audio;

    private void Awake()
    {
        // _audio = GetComponent<AudioSource>();
        // if (_audio == null)
        // { // if AudioSource is missing
            // Debug.LogWarning("AudioSource component missing from this gameobject. Adding one.");
            // let's just add the AudioSource component dynamically
            // _audio = gameObject.AddComponent<AudioSource>();
        // }
    }

    // Update is called once per frame
    void Update()
    {
        // move the player left or right
        if (Input.GetKey("down"))
        {
            dir = -1;
        }
        else if (Input.GetKey("up"))
        {
            dir = 1;
        }
        else
        {
            dir = 0;
        }

        pos = transform.position;
        pos.y += dir * speed * Time.deltaTime;
        
        
        if (pos.y >= -8.12 && pos.y <= 8.12)
        {
            // Debug.Log(transform.position.y);
            transform.position = pos;
            transform.position = new Vector2(-15f, transform.position.y);
        }

        // if ()
        // {
        //     transform.position = new Vector2(-15f, transform.position.y);
        // }

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            GameObject Capsules = new GameObject("Capsule");
            // instantiate laser on top of spaceship position
            Vector3 laserPos = transform.position;
            laserPos.y = -3.2f;
            newCapsule = Instantiate(Capsules, laserPos, transform.rotation) as GameObject;

            // play sound
            // playSound(laserSFX);
        }
        
    }

    private void playSound(AudioClip sound)
    {
        // _audio.PlayOneShot(sound);
    }
}
