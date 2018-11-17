using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject cam, combatController, dialogueController, menuController;

    public string attributes;

    public float speed;

    private Animator anim;

    [HideInInspector]
    private bool inMenu;

    [HideInInspector]
    private Vector3 cameraPos;

    private DialogueManger dman;
    private DialogueManger2 dman2;
    private DialogueManger3 dman3;
    private DialogueManger4 dman4;


    // Use this for initialization
    void Start()
    {
        inMenu = false;

        anim = GetComponent<Animator>();

        dman = FindObjectOfType<DialogueManger>();
        dman2 = FindObjectOfType<DialogueManger2>();
        dman3 = FindObjectOfType<DialogueManger3>();
        dman4 = FindObjectOfType<DialogueManger4>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = new Vector3(transform.position.x, transform.position.y, -5);
        cam.transform.position = cameraPos;

        if (dman.canmove == false && dman2.canmove == false && dman3.canmove == false && dman4.canmove == false)
        {
            if (!inMenu)
            {

                Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
                transform.GetComponent<Rigidbody2D>().AddForce(movement);

                anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
                anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
            }
        }
    }
}