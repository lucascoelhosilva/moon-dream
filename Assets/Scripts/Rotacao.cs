using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    [SerializeField]
    public float Rotate;

    void Update()
    {
        transform.Rotate(0, 0, Rotate);
    }
}
