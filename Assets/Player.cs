using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float force = 10.0f;
    Vector2 inputVector = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.AddForce(inputVector,ForceMode2D.Impulse);
        inputVector = Vector2.zero;
    }
}
