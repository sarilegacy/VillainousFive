using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject cam, combatController, dialogueController, menuController;

    public string attributes;

    public float speed;

    private Animator anim;

	public Vector2 lastMove;


    [HideInInspector]
    private bool inMenu;

    [HideInInspector]
    private Vector3 cameraPos;

    // Use this for initialization
    void Start()
    {
        inMenu = false;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = new Vector3(transform.position.x, transform.position.y, -5);
        cam.transform.position = cameraPos;

		Vector2 movement = new Vector2 (Input.GetAxis ("Horizontal") * speed, Input.GetAxis ("Vertical") * speed);

        if (!inMenu)
        {
			if (movement != Vector2.zero) 
			{
				anim.SetBool ("IsPlayerMoving", true);
				anim.SetFloat ("MoveX", movement.x);
				anim.SetFloat ("MoveY", movement.y);

				lastMove = new Vector2 (Input.GetAxis ("Horizontal") * speed, Input.GetAxis ("Vertical") * speed);

			} else 
				anim.SetBool ("IsPlayerMoving", false);
				transform.GetComponent<Rigidbody2D> ().AddForce (movement);

				anim.SetFloat ("LastMoveX", lastMove.x);
				anim.SetFloat ("LastMoveY", lastMove.y);
        }

    }
}