using UnityEngine;

public class Scoring_Balls : MonoBehaviour
{
    private Rigidbody rb;
    public int score = 0;

    


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
        if (other.gameObject.CompareTag("Ball_Potted"))
        {
            score++;
            other.gameObject.SetActive(false);

        }


    }

}
