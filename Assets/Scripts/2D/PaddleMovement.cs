using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
	public float speed = 2f;
	public float maxHeight = 5f;

	Transform paddleTransform;

    void Start()
    {
		paddleTransform = transform;
    }

    void Update()
    {
		float input = Input.GetAxis("Vertical");

		paddleTransform.Translate(Vector3.up * input * Time.deltaTime * speed);

		Vector3 position = paddleTransform.position;
		position.y = Mathf.Clamp(paddleTransform.position.y, -maxHeight, maxHeight);
		paddleTransform.position = position;
    }
}
