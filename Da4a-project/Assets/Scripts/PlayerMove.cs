using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PlayerMove : MonoBehaviour {

    Rigidbody2D rbody;
    Animator anim;
    Image hunger;
    Image stamina;
    Image sprite;
    public bool isWaiting = false;
    public int waySide;

	void Start () {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        hunger = GameObject.FindGameObjectWithTag("Hunger").GetComponent<Image>();
        sprite = GameObject.FindGameObjectWithTag("Sprite").GetComponent<Image>();
        stamina = GameObject.FindGameObjectWithTag("Stamina").GetComponent<Image>();
    }
	

	void Update () {
        if (!isWaiting) { 

            Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

            if (movement_vector != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x",movement_vector.x);
                anim.SetFloat("input_y", movement_vector.y);
                hunger.fillAmount = hunger.fillAmount - 0.00006f;
                stamina.fillAmount = stamina.fillAmount - 0.00009f;
                sprite.fillAmount = sprite.fillAmount - 0.00008f;


                if (Math.Abs(movement_vector.x) > Math.Abs(movement_vector.y))
                    if (movement_vector.x < 0f) waySide = 1;
                    else waySide = 3;
                else
                    if (movement_vector.y < 0f) waySide = 4;
                    else waySide = 2;

            }
            else {
                anim.SetBool("iswalking", false);
            }
            rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);
        }
        else
            anim.SetBool("iswalking", false);
    }
}
