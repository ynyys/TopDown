using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    //Set player move speed
    public float moveSpeed = 2.0f;
    //Player direction
    Vector2 movDir; //movDir(x,y) w =1, s =-1
    Rigidbody2D rb2d;

    Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movDir.x = Input.GetAxisRaw("Horizontal"); //x =1 or x=-1
        movDir.y = Input.GetAxisRaw("Vertical");

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //Movement
    private void FixedUpdate()
    {
        Move();
        RotateToMousePos();
    }


    public void Move()
    {
        rb2d.MovePosition(rb2d.position + movDir * moveSpeed * Time.fixedDeltaTime);
    }

    public void RotateToMousePos()
    {
        Vector2 dirToMousePos = mousePos - rb2d.position;
        float angle = Mathf.Atan2(dirToMousePos.y, dirToMousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //transform.up = new Vector2(dirToMousePos.x, dirToMousePos.y);
    }
}
