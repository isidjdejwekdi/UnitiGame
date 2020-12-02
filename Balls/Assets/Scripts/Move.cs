using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 300f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Vertical") > 0)
        //{
        //    transform.Translate(transform.right * speed);
        //}
        //else if (Input.GetAxis("Vertical") < 0)
        //{
        //    transform.Translate(-transform.right * speed);
        //}

        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    transform.Translate(-transform.forward * speed);
        //}
        //else if (Input.GetAxis("Horizontal") < 0)
        //{
        //    transform.Translate(transform.forward * speed);
        //}

        Vector3 movement = (Input.GetAxis("Vertical") * -Vector3.forward * speed) + (Input.GetAxis("Horizontal") * -Vector3.right * speed);
        movement *= Time.deltaTime;
        GetComponent<Rigidbody>().AddForce(movement, ForceMode.Force);


    }
}
