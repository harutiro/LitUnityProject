using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	Rigidbody rigidbody;
	public GameObject bullet;

	// Use this for initialization
	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bullet, transform.position, transform.rotation);
		}

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up * 40f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.up * -40f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			rigidbody.velocity = transform.forward * 5f;
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			rigidbody.velocity = transform.forward * -5f;
		}
	}
}

