using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    [SerializeField] Vector3 offset = new Vector3(0, 16, -15);

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offset;
    }
}
