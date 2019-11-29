using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed = 3f;
	Rigidbody2D rb;

	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		Vector2 velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
		rb.velocity = velocity * speed;

	}
}
