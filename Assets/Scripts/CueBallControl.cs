using UnityEngine;
using TMPro;


public class CueBallControl : MonoBehaviour

{
    //declare variables
    bool canPlay = true;
    bool leftPressed = false;
    bool rightPressed = false;

    public int Power = 4;


    public TextMeshProUGUI displayText ;

    public Rigidbody rb;
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
        rb = GetComponent<Rigidbody>(); // taken from roll a ball - moving the player
    }

    // Update is called once per frame
    void Update()
    {
        //check if all balls are stationary
        if (rb.linearVelocity.magnitude == 0f && Colourball1.linearVelocity.magnitude == 0f && Colourball2.linearVelocity.magnitude == 0f && Colourball3.linearVelocity.magnitude == 0f && Colourball4.linearVelocity.magnitude == 0f && Colourball5.linearVelocity.magnitude == 0f && Colourball6.linearVelocity.magnitude == 0f && Colourball7.linearVelocity.magnitude == 0f && Colourball8.linearVelocity.magnitude == 0f && Colourball9.linearVelocity.magnitude == 0f && Colourball10.linearVelocity.magnitude == 0f && Colourball11.linearVelocity.magnitude == 0f && Colourball12.linearVelocity.magnitude == 0f && Colourball13.linearVelocity.magnitude == 0f && Colourball14.linearVelocity.magnitude == 0f && Colourball15.linearVelocity.magnitude == 0f)
        {
            
            //sets can play to true
            canPlay = true;

        }
        else
        {

            //sets can play to false
            canPlay = false;
           
        }

        //allows movement if can play is true
        if (canPlay)
        {
            //checks if right arrow is pressed
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rightPressed = true;
            }
            else
            {
                rightPressed = false;
            }

            //checks if left arrow is pressed
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                leftPressed = true;
            }
            else
            {
                leftPressed = false;
            }

            //if both are pressed then it should act the same as none being pressed so both are set to false
            if (leftPressed && rightPressed)
            {
                rightPressed = false;
                leftPressed = false;
            }

            
            if (leftPressed)
            {
                //spin the cue ball left
                transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);  //from roll a ball tutorial, creating collectables
            }

            if (rightPressed)
            {
                //spin the cue ball right
                transform.Rotate(new Vector3(0, -50, 0) * Time.deltaTime);  //from roll a ball tutorial, creating collectables
            }


            //check if space is pressed and return true for a frame
            if (Input.GetKeyDown(KeyCode.Space))
            {

                //add a force to shoot the ball
                rb.AddRelativeForce(Vector3.forward * (Power * 4));

            }

            //convert power to string and display it
            displayText.text = Power.ToString();

        }
        else
        {

            //when the user cant play, constantly set rotation to 0,0,0
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }

           //check if up is pressed and return true for a frame
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                 //increases power by 1 with it capped at 50
                if (Power < 50)
                {
                    Power += 1;
                }
            }

        //check if down is pressed and return true for a frame
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
            //decreases power by 1 with it capped at 0    
            if (Power > 0)
                {
                    Power -= 1;
                }

            }

    }

}



