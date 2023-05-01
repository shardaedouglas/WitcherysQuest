using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{

    public GameObject player;
    public Vector3 myPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      GetComponent<Animator>().Play("collectibleAnimation");


    
    }
    void OnTriggerEnter(Collider other)
    {
     
      if (other.tag == "Player")
      {
        PlayerController player = other.GetComponent<PlayerController>();
        //player.AddScrolls();
        Destroy(this.gameObject);
      }
    }
}
