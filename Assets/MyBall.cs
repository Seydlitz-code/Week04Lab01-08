using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
	Rigidbody rigid;

	void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		//rigid.velocity = Vector3.forward; //#1.속력 바꾸기

		if (Input.GetButtonDown("Jump"))
		{
			rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
		}

		Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		rigid.AddForce(vec, ForceMode.Impulse);

		//회전
		//rigid.AddTorque(Vector3.up);
		//rigid.AddTorque(Vector3.down);
	}
	private void OnTriggerStay(Collider other)
	{
		if (other.name == "Cube")
		{
			rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
		}
	}
	public void Jump()
	{
		rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
	}
}
