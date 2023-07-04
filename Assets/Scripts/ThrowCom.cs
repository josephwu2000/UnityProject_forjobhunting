using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCom : MonoBehaviour
{
    public GameObject birdPrefab;

    public float birdSpeed = 15f;

    public Collider playerCollider;

    public AudioClip triggerSound;

    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject newObj = Instantiate(birdPrefab);
            newObj.GetComponent<Rigidbody>().position = transform.position;
            newObj.GetComponent<Rigidbody>().velocity =
                transform.forward * birdSpeed;
            
            Physics.IgnoreCollision(playerCollider, newObj.GetComponent<Collider>(), true);

            audioSource.PlayOneShot(triggerSound);
        }
    }
}
