using UnityEngine;

public class checkballvelocity : MonoBehaviour
{
    public Rigidbody rb;
    public bool stationary;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.magnitude == 0f)
        {

            stationary = true;

        }
        else
        {

            stationary = false;

        }
    }
}
