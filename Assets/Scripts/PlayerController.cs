using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10.0f;

    InputAction moveHorizontal;

    public Rigidbody2D rb;
    private float moveX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnValidate()
    {
        if (moveHorizontal == null)
        {
            moveHorizontal = new InputAction(type: InputActionType.Button);
        }
        if (moveHorizontal.bindings.Count == 0)
        {
            moveHorizontal.AddCompositeBinding("1DAxis")
                .With("Positive", "<Keyboard>/rightArrow")
                .With("Negative", "<Keyboard>/leftArrow");
        }

    }

      private void OnEnable() {
        moveHorizontal.Enable();
    }

    private void OnDisable() {
        moveHorizontal.Disable();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = moveHorizontal.ReadValue<float>();
        moveX = horizontal * moveSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }
}
