using UnityEngine;

public class Scoring_Balls : MonoBehaviour
{
    private Rigidbody rb;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

    }

}
