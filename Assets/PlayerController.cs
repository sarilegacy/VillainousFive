using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject cam, combatController, dialogueController, menuController;

    public float speed;

    [HideInInspector]
    private bool inMenu;

    [HideInInspector]
    private Vector3 cameraPos;

    // Use this for initialization
    void Start () {
        inMenu = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        cameraPos = new Vector3(transform.position.x, transform.position.y, -5);
        cam.transform.position = cameraPos;

        if (!inMenu)
        {

            Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
            transform.GetComponent<Rigidbody2D>().AddForce(movement);
        }
	}
}
