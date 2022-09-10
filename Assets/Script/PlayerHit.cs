using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject enemy;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        var length = (enemy.transform.position - player.transform.position).magnitude;
        var r = 1f;
        var hitlength = r + r;

        if (length <= hitlength)
        {
            // enemy.GetComponent<MeshRenderer>().materials[0].color = Color.red;
            Destroy(player.gameObject);
        }
        else
        {
            enemy.GetComponent<MeshRenderer>().materials[0].color = Color.white;
        }
    }
}
