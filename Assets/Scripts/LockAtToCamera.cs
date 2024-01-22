using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LockAtToCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        
    }
    public void ReverseRotaion()
    {
     
    }

}
