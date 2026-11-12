using UnityEngine;

[ExecuteInEditMode]
public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public float offsetDistance = -15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = ball.rotation * Quaternion.AngleAxis(90, Vector3.up);
        Vector3 fwd = ball.TransformDirection(Vector3.fwd);
        transform.position = ball.position + fwd * offsetDistance;
            //make it have cue balls position - an amount, then set its rotation to match.
            //also make turn system which resets cue ball rotation after all balls stop
    }
}
