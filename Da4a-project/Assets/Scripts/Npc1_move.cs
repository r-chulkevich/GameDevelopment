using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Npc1_move : MonoBehaviour
{

    Rigidbody2D rbody;
    Animator anim;
    public bool isWaiting = false;
    private float goX;
    private float goY;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isWaiting)
        {

            System.Random rnd = new System.Random();
            goX = rnd.Next(1, 10) / 10;
            goY = rnd.Next(1, 10) / 10;

            Vector2 movement_vector = new Vector2(0.1f, 0);

            if (movement_vector != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector.x);
                anim.SetFloat("input_y", movement_vector.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }
            rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);
        }
        else
            anim.SetBool("iswalking", false);
    }
}
