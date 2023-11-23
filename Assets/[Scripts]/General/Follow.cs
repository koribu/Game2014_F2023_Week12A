using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    GameObject _followingObject;
   
    void Update()
    {
        transform.position = _followingObject.transform.position;
    }
}
