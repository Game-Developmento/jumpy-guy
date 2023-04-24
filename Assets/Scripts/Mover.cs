using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    [SerializeField] public Vector3 velocity;
    private Vector3 screenPos;
    [SerializeField] public string triggerTag;

    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position += velocity * Time.deltaTime;

        }
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.activeSelf && other.collider.tag == triggerTag)
        {
            SceneManager.LoadScene("level-3");
        }
    }
  

}
