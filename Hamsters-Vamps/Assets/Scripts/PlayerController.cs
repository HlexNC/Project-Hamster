using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    [SerializeField] float _playerInputVer;
    [SerializeField] float _playerInputHor;
    [SerializeField] int playerSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerInputVer = Input.GetAxis("Vertical");
        _playerInputHor = Input.GetAxis("Horizontal");
        _playerRb.AddForce(Vector3.forward * (playerSpeed * _playerInputVer));
        _playerRb.AddForce(Vector3.right * (playerSpeed * _playerInputHor));
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water")) {
            gameObject.transform.position = new Vector3(0, 1, 0); }
    }
    */
}
