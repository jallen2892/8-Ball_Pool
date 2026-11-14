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

    private void OnTriggerEnter(Collider other)//Function that triggers when a ball collides with the holes
    {
        if (other.gameObject.CompareTag("Ball_Potted"))//Checking if it is one of the balls and not the cue ball
        {
            score++;//Increasing the score
            other.gameObject.SetActive(false);//Making the balls inactive to act as though they have been potted

        }


    }

}
