using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

//use this script to control all your general inputs 


public class HitCollider : MonoBehaviour
    {
        void Update()
        {
     
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "About") 
            {
                if (hit.collider != null)
                {

                    //something happens 
                }
            }
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Tag01")
            {
                if (hit.collider != null)
                {
                  
                    SceneManager.LoadScene(1); //myscene01
                }
            }
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Tag02")
            {
                if (hit.collider != null)
                {
                   
                    SceneManager.LoadScene(2); //myscene02
            }
            }
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Tag03")
            {
                if (hit.collider != null)
                {
                   
                    SceneManager.LoadScene(3); //myscene03
            }
            }
        }
}

}


