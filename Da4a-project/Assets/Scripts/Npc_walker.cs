using UnityEngine;
using System.Collections;

public class Npc_walker : MonoBehaviour {

    public float mSpeed;
    private Rigidbody2D npcW;
    private bool moving;

    private bool way = false;
    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;
    Animator anim;

    void Start () {
        npcW = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        timeBetweenMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;
	}
	
	void Update () {

        if (moving)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", moveDirection.x);
            anim.SetFloat("input_y", moveDirection.y);

            timeBetweenMoveCounter -= Time.deltaTime;
            npcW.velocity = moveDirection;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = timeBetweenMove;
            }

        } else {
            anim.SetBool("iswalking", true);
            timeBetweenMoveCounter -= Time.deltaTime;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = timeToMove;
                if  ((npcW.position.x > 25f) && (!way))
                    moveDirection = new Vector3(-0.25f * mSpeed, 0f, 0f);
                else {
                    way = true;
                    moveDirection = new Vector3(0.25f * mSpeed, 0f, 0f);
                    if (npcW.position.x > 28.7f) way = false;
                }
            }
        }
	}
}
