using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3.0f;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

		if (moveHorizontal == 0.0F) {
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		} else {

			if (rb.velocity.x == 0.0F) {
				Vector3 movement = Vector3.zero;
				if (moveHorizontal > 0.0)
					movement = new Vector3 (speed, 0.0f, 0.0f);
				else
					movement = new Vector3 (speed * -1F, 0f, 0f);

				rb.AddForce (movement);
			}
			
		}
		
        
    }
}
