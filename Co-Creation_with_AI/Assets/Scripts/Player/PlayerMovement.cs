using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playerModel;
    private const float DefaultMoveSpeed = 2f;
    private const float BoostedMoveSpeed = 4f; // 追加されたスピード
    private const float JumpForce = 5f;
    private const float SecondJumpForce = 3f;
    private bool isGrounded;
    private bool canDoubleJump;

    private void Update()
    {
        // プレイヤーの動きを計算
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 cameraForward = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraRight = Vector3.Scale(mainCamera.transform.right, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = (cameraForward * verticalInput + cameraRight * horizontalInput).normalized;

        // "ｚ" ボタンが押されたらスピードを上げる
        float moveSpeed = Input.GetKey(KeyCode.Z) ? BoostedMoveSpeed : DefaultMoveSpeed;

        transform.position += moveDirection * Time.deltaTime * moveSpeed;

        // プレイヤーの向きを設定
        if (moveDirection != Vector3.zero)
        {
            playerModel.transform.rotation = Quaternion.LookRotation(moveDirection);
        }

        // ジャンプ処理
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 初回のジャンプ
                GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
                isGrounded = false;
                canDoubleJump = true;
            }
        }
        else if (canDoubleJump && Input.GetKeyDown(KeyCode.Space))
        {
            // 二段階のジャンプ
            GetComponent<Rigidbody>().AddForce(Vector3.up * SecondJumpForce, ForceMode.Impulse);
            canDoubleJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // プレイヤーが地面に接触しているか判定
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            canDoubleJump = false;
        }
    }
}
