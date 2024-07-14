using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {   
        if (other.gameObject.tag == "Player")
        {
            var meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;
        }
    }    
}
