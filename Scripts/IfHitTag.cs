using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfHitTag : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject trashElement;
    public GameObject trashCan;
    public GameObject prefab;
    public Rigidbody rb;

    public float speed;

    void Awake ()
    {


    }

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.CompareTag("TrashCan"))
            {
            rb.isKinematic = false;

            Destroy(trashElement);

            for (int i = 0; i < 1; i++)
                Instantiate(prefab, new Vector3(i * -0.06f, 1.9704f, 10.9f), Quaternion.identity);

            trashCan.transform.Rotate(Vector3.up * speed * 360);

            Debug.Log("hit");

        }

        }

}
