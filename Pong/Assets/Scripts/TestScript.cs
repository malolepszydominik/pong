using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private IRacketMovement racketMovement;

    void Awake()
    {
        racketMovement = transform.GetComponent<IRacketMovement>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            racketMovement.MoveUp();
        }

        if (Input.GetKey(KeyCode.S))
        {
            racketMovement.MoveDown();
        }

    }
}
