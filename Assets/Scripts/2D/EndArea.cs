using UnityEngine;

public class EndArea : MonoBehaviour
{
	private void OnTriggerExit2D(Collider2D collision)
	{
		collision.transform.position = Vector2.zero;
	}
}
