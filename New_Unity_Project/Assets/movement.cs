using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb; //reference to the Rigidbody component called "rb"

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    /* marked as "Fixed"Update becouse we
     * are using it to mess with phisics*/
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime , 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


    }
}
