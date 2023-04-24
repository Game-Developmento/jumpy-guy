using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10.0f;

    [SerializeField] InputAction moveHorizontal;

    public Rigidbody2D rb;
    private float moveX;
    [SerializeField] string currentScene;
    private bool reachEnd;

    private bool restartGame;

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

    private void OnEnable()
    {
        moveHorizontal.Enable();
    }


    public void setRestartGame(bool value)
    {
        restartGame = value;
    }
    private void OnDisable()
    {
        moveHorizontal.Disable();

    }

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
    private void OnBecameInvisible()
    {
        if (!reachEnd && !restartGame)
        {
            Debug.Log("Loading scene: " + currentScene);
            SceneManager.LoadScene(currentScene);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject && other.gameObject.tag == "NextLevel")
        {
            reachEnd = true;
        }
        else if (other.gameObject && other.gameObject.tag == "Spikes")
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
