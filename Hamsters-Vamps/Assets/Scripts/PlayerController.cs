using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    float _playerInputVer;
    float _playerInputHor;
    [SerializeField] int playerSpeed = 200;
    float verticMoveDir;
    float horizMoveDir;

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
        float verticMoveDir = (playerSpeed * _playerInputVer) * Time.fixedDeltaTime;
        float horizMoveDir = (playerSpeed * _playerInputHor) * Time.fixedDeltaTime;
        _playerRb.AddForce(verticMoveDir, 0, horizMoveDir);
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water")) {
            gameObject.transform.position = new Vector3(0, 1, 0); }
    }
    */
}
