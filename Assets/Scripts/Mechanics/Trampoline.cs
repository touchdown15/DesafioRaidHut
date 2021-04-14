using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private GameObject playerObj;
    private Rigidbody2D playerRB;
    private PlayerController playerController;
    float impulseSpeed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
        playerController = playerObj.GetComponent<PlayerController>();
        playerRB = playerObj.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if(playerController.IsGrounded ){
            playerRB.velocity = new Vector2 (0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player" && !playerController.IsGrounded){
            playerRB.velocity = new Vector2(0, impulseSpeed);
        }
    }

}
