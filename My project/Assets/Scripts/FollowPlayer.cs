using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
   public Transform p1;
   public Transform p3;
          int Visao;
    // Start is called before the first frame update
    void Start()
    {
        Visao = 1;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        if (Input.GetKeyDown("p")) {
           if (Visao == 1) {
            Visao = 3;
            transform.position = p3.position;
            }
            else
            {
               Visao = 1;
               transform.position = p1.position;
            } 
        }

   
        
    }
}
