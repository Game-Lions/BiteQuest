using UnityEngine;
using UnityEngine.InputSystem;

public class MovmentDog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] InputAction move = new InputAction(type: InputActionType.Value, expectedControlType: nameof(Vector2));
    [SerializeField] float speed = 5f; // מהירות תנועה
    private Rigidbody2D rb;
    void OnEnable()
    {
        move.Enable();
    }
    void OnDisable()
    {
        move.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputMovement = move.ReadValue<Vector2>();

        // חישוב מיקום חדש
        Vector2 newPosition = rb.position + inputMovement * speed * Time.deltaTime;

        // עדכון מיקום ה-Rigidbody
        rb.MovePosition(newPosition);
    }
}
