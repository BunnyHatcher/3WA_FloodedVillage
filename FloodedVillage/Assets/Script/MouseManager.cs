using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Camera _camera;
    public GameObject SandPrefab;
    public GameObject WaterPrefab;
    public GameObject EmptyPrefab;

   

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

            if (Input.GetMouseButtonDown(0) && hit.collider.CompareTag("Sand"))
            {
                Debug.Log("Touchdown!");
                Destroy(hit.collider.gameObject);
                Instantiate(EmptyPrefab, hit.transform.position, Quaternion.identity);
            }

        }

        else
        {
            Debug.Log("Missed!"); 
        }
        
        
    }



    
}
