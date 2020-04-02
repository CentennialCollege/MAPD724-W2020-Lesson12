using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MegaManController : MonoBehaviour
{
    public Animator controller;
    public SpriteRenderer renderer;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        // move to the right
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            // run animation
            controller.SetInteger("AnimState", 1);
            renderer.flipX = false;
        }

        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            // idle animation
            controller.SetInteger("AnimState", 0);
        }

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            // run animation
            controller.SetInteger("AnimState", 1);
            renderer.flipX = true;
        }

        if (Input.GetAxis("Jump") > 0.1f)
        {
            //controller.SetInteger("AnimState", 2);
        }
    }
}
