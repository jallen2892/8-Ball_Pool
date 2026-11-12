using UnityEngine;

public class CueBallControl : MonoBehaviour
{
    bool canPlay = true;
    bool leftPressed = false;
    bool rightPressed = false;
    public Rigidbody rb;
    public int Power = 4;


    public Rigidbody Colourball1;
    public Rigidbody Colourball2;
    public Rigidbody Colourball3;
    public Rigidbody Colourball4;
    public Rigidbody Colourball5;
    public Rigidbody Colourball6;
    public Rigidbody Colourball7;
    public Rigidbody Colourball8;
    public Rigidbody Colourball9;
    public Rigidbody Colourball10;
    public Rigidbody Colourball11;
    public Rigidbody Colourball12;
    public Rigidbody Colourball13;
    public Rigidbody Colourball14;
    public Rigidbody Colourball15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rb.linearVelocity.magnitude == 0f && Colourball1.linearVelocity.magnitude == 0f && Colourball2.linearVelocity.magnitude == 0f && Colourball3.linearVelocity.magnitude == 0f && Colourball4.linearVelocity.magnitude == 0f && Colourball5.linearVelocity.magnitude == 0f && Colourball6.linearVelocity.magnitude == 0f && Colourball7.linearVelocity.magnitude == 0f && Colourball8.linearVelocity.magnitude == 0f && Colourball9.linearVelocity.magnitude == 0f && Colourball10.linearVelocity.magnitude == 0f && Colourball11.linearVelocity.magnitude == 0f && Colourball12.linearVelocity.magnitude == 0f && Colourball13.linearVelocity.magnitude == 0f && Colourball14.linearVelocity.magnitude == 0f && Colourball15.linearVelocity.magnitude == 0f)
        {

            canPlay = true;

        }
        else
        {

            canPlay = false;
           

        }

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


            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (Power < 50)
                {
                    Power += 1;
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                if (Power > 0)
                {
                    Power -= 1;
                }

            }

            if (Input.GetKey(KeyCode.Space))
            {

                rb.AddRelativeForce(Vector3.forward * Power);

            }
            

        }

    }
}


