using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  
public class camSpan : MonoBehaviour
{

    public GameObject player ;
    //public Transform targetObject;
    public Vector3 cameraOffset;
    public float smoothFactor = .1f;
    public float rotationSpeed = 0.5f;
    public int speed = 2;
    public Vector3 finalOffset;
   

    

    // Start is called before the first frame update
    void Start()
    {

        cameraOffset = transform.position - player.transform.position;
        finalOffset = cameraOffset;
        
    }
    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = Vector3.Lerp(transform.position, player.transform.position + finalOffset, .3f);
        Rotate();

       //transform.position = player.transform.position + finalOffset;

        /*Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        //Rotate();

        /*float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation,rotationSpeed * Time.deltaTime );
        }
        void Rotate()
        {
            finalOffset = Quaternion.AngleAxis(Input.GetAxis("Horizontal")*4f, Vector3.up) * finalOffset;
        }*/

        
    }
    void Rotate()
    {
        finalOffset =  Quaternion.AngleAxis(Input.GetAxis("Mouse X") *4, Vector3.up) * finalOffset;
        transform.LookAt(player.transform.position);
    }
}  
