using UnityEngine;

public class CueBallControl : MonoBehaviour
{
    bool canPlay = true;
    bool leftPressed = false;
    bool rightPressed = false;
    public Rigidbody rb;
    int Power = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPlay)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rightPressed = true;
            }
            else
            {
                rightPressed = false;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                leftPressed = true;
            }
            else
            {
                leftPressed = false;
            }

            if (leftPressed && rightPressed)
            {
                rightPressed = false;
                leftPressed = false;
            }

            if (leftPressed)
            {
                transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);  //from roll a ball tutorial, creating collectables
            }

            if (rightPressed)
            {
                transform.Rotate(new Vector3(0, -50, 0) * Time.deltaTime);  //from roll a ball tutorial, creating collectables
            }



            if (Input.GetKey(KeyCode.Space))
            {

                rb.AddRelativeForce(Vector3.forward * Power);

            }
        }
    }


}
