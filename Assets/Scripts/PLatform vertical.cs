using UnityEngine;
using Unity.VisualScripting;


public class PLatformvertical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float yvel = 5;
    float _currentTime = 5;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime = _currentTime - Time.deltaTime;
        yvel = rb.linearVelocity.y;
        if (_currentTime <= 5)
        {
            yvel = 5f;
        }
                
        rb.linearVelocity = new Vector3(0, +yvel);

        if (_currentTime <= 0)
        {
            yvel = -5f;
        }

        rb.linearVelocity = new Vector3(0, -yvel);

        if (_currentTime <= -5)
        {
            _currentTime = 5;
        }          


    }

}
