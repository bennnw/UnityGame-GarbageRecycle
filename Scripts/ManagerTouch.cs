using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerTouch : MonoBehaviour
{

    

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // input 01 - if trash element is touched [repeat this for ultiple elements ]


            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "News")
            {
                if (hit.collider != null)
                {

                  //something 
                }
            }

            // input 02 - if trash element collides the right trashcan [repeat this for ultiple elements ]

          




    


            // condition to create is - if after 10 second there is no collision - loose - reset 

        }

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
           //
        }

   
    }
}
