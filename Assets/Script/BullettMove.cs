using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullettMove : MonoBehaviour
{
    public float speed;
    public Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = moveDirection;
        transform.Translate(dir * speed * Time.deltaTime, Space.Self/*Space.World*/);
    }
}
