using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour {

    #region Veriables

    private Rigidbody rbody;
    private Collider collider;

    public float speed;
    public float jumpForce;

    #endregion
    
    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        rbody.velocity = Vector3.right * speed;
        if (InputManager.Jump()) {
            rbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
	}
}
