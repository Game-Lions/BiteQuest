using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player touched a hint
        if (other.CompareTag("Hint"))
        {
            Debug.Log("Player touched a hint!");
            Destroy(other.gameObject); // Remove the hint object
        }

        // Check if the player hit a wall
        if (other.CompareTag("Wall"))
        {
            Debug.Log("Player hit the wall!");
        }
    }
}
