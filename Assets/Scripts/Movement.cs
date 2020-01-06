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
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        var direction = new Vector3(0, 0, 0);


        //se premo il tasto muovi l'oggetto sull'asse corrispondente al tasto
        if(Input.GetAxis("Horizontal") != 0)
        {
            direction.z = horizontalMovement;
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            direction.y = verticalMovement;
        }

        transform.Translate(direction * (speed * Time.deltaTime));
    }
}
