using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class PlayerMoveMont : MonoBehaviour
{
   

    [SerializeField]
    [Header("�÷��̾� ������")]
    public float playerSpeed; // �ӵ�
    public float jumpForce;  // ���� ��

    public bool isGrounded; // �� üũ
    private Animator animator; // �ִϸ��̼�
    private Rigidbody playerRigidbody; // playerRigidbody

    private void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float xInput = Input.GetAxis("Horizontal"); // �¿�
        float zInput = Input.GetAxis("Vertical"); // ����

        Vector3 Movemont = new Vector3(xInput, 0, zInput).normalized;

        playerRigidbody.velocity = Movemont * playerSpeed * Time.deltaTime;

        animator.SetBool("IsWark", Movemont != Vector3.zero); //  ���ϸ��̼� ����

        transform.LookAt(transform.position + Movemont);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
    }


    private void Jump()
    {
        playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
