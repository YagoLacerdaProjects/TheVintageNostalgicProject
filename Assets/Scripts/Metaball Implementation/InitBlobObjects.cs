using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlobObjects : MonoBehaviour
{
	private SphereCollider m_collider;
	private Rigidbody rb;
	private BlobMovement movement;
	private int nrOfBlobs = 7;
    // Start is called before the first frame update
    void Start()
    {
		for (int i=0 ; i<nrOfBlobs ; i++) {

			GameObject child = new GameObject();
			child.transform.parent = this.gameObject.transform;
			child.transform.position = new Vector3(Random.value*1.5f, i, Random.value*1.5f);
			m_collider = child.gameObject.AddComponent<SphereCollider>();
			rb = child.gameObject.AddComponent<Rigidbody>();
			rb.useGravity = false;
			movement = child.gameObject.AddComponent<BlobMovement>();

			rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
			rb.mass = 1.0f;
			float floatationRadius = Mathf.Pow(( (3.0f*rb.mass) / (4.0f*Mathf.PI) ), (1f/3f));
			float r = Random.Range(0f,0.05f);
			m_collider.radius = floatationRadius+r;
		}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
