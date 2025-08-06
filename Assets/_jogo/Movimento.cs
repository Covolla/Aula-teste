using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}

    private void MoveEsquerda()
    {
        gameObject.transform.position = new Vector3(-1, 0, 0);
    }

    private void MoveDireita()
    {
        gameObject.transform.position = new Vector3(1, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveEsquerda();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveDireita();
        }
   
   
   
   
   
    }






}


