using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    // Update is called once per frame
    void Update()
    {
        //se premo il tasto muovi l'oggetto sull'asse corrispondente al tasto
        if(Input.GetAxis("Horizontal") != 0)
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("Stai andando a destra");
            }
            else
            {
                Debug.Log("Stai andando a sinistra");
            }
        }
    }
}
