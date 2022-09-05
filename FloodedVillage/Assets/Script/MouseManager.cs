using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Camera _camera;

   

    private void Start()
    {
        
    }


    private void Update()
    {
          
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
        //Debug.Log(hit.collider.name);

        //to prevent Null reference errors when touching anything else but the layermask
        if(hit.collider != null)
        {
            Debug.Log(hit.collider.name);

            if (hit.collider.CompareTag("Sand"))
            {
                Debug.Log("Touchdown!");
            }

        }

        else
        {
            Debug.Log("Missed!"); 
        }
        
        
    }



    
}
