using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullettHit : MonoBehaviour
{
    [SerializeField]
    public GameObject bullet;
    [SerializeField]
    public GameObject enemy;

    // Start is called before the first frame update

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        var length = (enemy.transform.position - bullet.transform.position).magnitude;
        var r = 0.5f;
        var hitlength = r + r;

        if (length <= hitlength)
        {
            // enemy.GetComponent<MeshRenderer>().materials[0].color = Color.red;
            Destroy(enemy.gameObject);
            Destroy(this.gameObject);
        }

    }
}
