using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{
	GravityModifier planet;
	Rigidbody rigidbody;

	void Awake()
	{
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityModifier>();
		rigidbody = GetComponent<Rigidbody>();

		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		rigidbody.useGravity = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
	}
    private void FixedUpdate()
    {
		planet.Attract(rigidbody);
    }
}
