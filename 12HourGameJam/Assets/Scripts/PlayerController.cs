﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeedBase;
    private float moveSpeed;
    public bool playerCanMove;

    [SerializeField] private Collider2D playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = moveSpeedBase;
        playerCanMove = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            // up
            MoveUp();
        }

        if (Input.GetKey("d")) {
            // right
            MoveRight();
        }

        if (Input.GetKey("s")) {
            // down
            MoveDown();
        }

        if (Input.GetKey("a")) {
            // left
            MoveLeft();
        }

        if (playerCanMove) {
            moveSpeed = moveSpeedBase;
        } else {
            moveSpeed = 0;
        }
    }

    void MoveUp() {
        // move up
        transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
    }

    void MoveRight() {
        // move right
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    void MoveDown() {
        // move down
        transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
    }

    void MoveLeft() {
        // move left
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }

    void OnTriggerStay2D (Collider2D collision) {

        if (Input.GetKeyDown("q")) {
            if (collision.tag == "item") {
                Destroy(collision.gameObject);
            }
        }

        if (Input.GetKeyDown("e")) {
            if (collision.tag == "villager") {
                playerCanMove = false;
            }
        }
    }

}
