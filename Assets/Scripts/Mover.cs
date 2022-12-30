using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction() {
        Debug.Log("welcome to the game");
        Debug.Log("Move your player with wasd or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0f, zValue);
    }
}
