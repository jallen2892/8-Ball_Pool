using UnityEngine;

public class Scoring_Balls : MonoBehaviour
{
    private Rigidbody rb;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Exists");
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("1");
        Debug.Log(collision.gameObject.name, collision.gameObject);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("3");
        Debug.Log(collision.gameObject.name, collision.gameObject);
    }
}
