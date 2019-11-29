using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 3f;
	public float jump = 20f;
	Rigidbody rb;
	Vector3 movement = new Vector3();
	bool canJump = false;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		movement.x = Input.GetAxis("Horizontal");
		movement.z = Input.GetAxis("Vertical");

		if (Input.GetKey(KeyCode.Space) && canJump)
			rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

		
		Collider[] cols = Physics.OverlapSphere(transform.position + Vector3.down, 0.1f);
		if (cols.Length > 1)
		{
			Debug.Log(cols[0].name);
			canJump = true;
		}
		else
			canJump = false;
	}

	private void FixedUpdate()
	{
		rb.MovePosition(transform.position + movement * Time.fixedDeltaTime * speed);
	}
}


