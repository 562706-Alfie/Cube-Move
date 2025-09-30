using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb;
    float yvel = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yvel = rb.linearVelocity.y;
    }

    void OnCollisionEnter2D(Collider2D PlatformTop)
    {
        ;
    }
}
