using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleControl : MonoBehaviour
{

    public Text helpText;
    public PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    void OnMouseDown()
    {
        if(player._collectedScroll == 2  && Input.GetMouseButtonDown(0)) 
        {
            Destroy(GameObject.FindWithTag("O1"));
            helpText.text = "Proceed... \n Find more Scrolls";
        }

        if(player._collectedScroll == 3  && Input.GetMouseButtonDown(0)) 
        {
            Destroy(GameObject.FindWithTag("O2"));
            helpText.text = "";
        }
        if(player._collectedScroll == 4  && Input.GetMouseButtonDown(0)) 
        {
            Destroy(GameObject.FindWithTag("O3"));
            helpText.text = "";
        }
        if(player._collectedScroll == 6  && Input.GetMouseButtonDown(0)) 
        {
            Destroy(GameObject.FindWithTag("O4"));
            helpText.text = "You Win !";
        }
        
    }
    
}
