using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	float timer;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward * 12f + Vector3.up * 8f;
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer > 10f)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Target"){
			other.gameObject.GetComponent<MeshRenderer>().material.color=Color.blue;
			Destroy(gameObject);
		}
	}
}
