using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc1_move : MonoBehaviour
{

    Rigidbody2D rbody;
    Animator anim;
    public bool isWaiting = false;

    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isWaiting)
        {

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
