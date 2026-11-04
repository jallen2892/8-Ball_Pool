using UnityEngine;

public class FollowBall : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3()
            //make it have cue balls position - an amount, then set its rotation to match.
            //also make turn system which resets cue ball rotation after all balls stop
    }
}
