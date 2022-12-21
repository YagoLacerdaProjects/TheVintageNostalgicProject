using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMovement : MonoBehaviour
{
	public float environmentDensity = 1.0f; //reference density
	public float blobDensity;

	private float y_force;
	private Rigidbody rb;
	private SphereCollider s_collider;

    // Start is called before the first frame update
    void Start()
    {
		rb = this.gameObject.GetComponent<Rigidbody>();
		s_collider = this.gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
		blobDensity = (3*rb.mass) / (4 * Mathf.PI * Mathf.Pow(s_collider.radius, 3));

		y_force = Random.value * 0.5f * (environmentDensity - blobDensity);
    }
	void FixedUpdate () 
	{
		//Debug.Log("bd "+blobDensity);
		//Debug.Log("yf "+y_force);
		//Randomness added to sideways movement to create more interesting movement
		rb.AddForce(new Vector3(Random.Range(-1f,1f),y_force,Random.Range(-1f,1f)));
	}
}
