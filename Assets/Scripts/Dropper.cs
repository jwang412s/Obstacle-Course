 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float waitTime = 3f;

    //[SerializeField] float restartTime = Time.time % 2;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime && rigidbody.useGravity == false) {
            renderer.enabled = true;
            rigidbody.useGravity = true;
            rigidbody.AddForce(0, -50000, 0, ForceMode.Force);
        } 
    }

    private void OnCollisionEnter(Collision other) {
        rigidbody.useGravity = false;
        rigidbody.AddForce(0, 60000, 0, ForceMode.Force);
    }
}
