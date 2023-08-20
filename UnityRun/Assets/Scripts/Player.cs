using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	/// <summary>
	/// 前に進むスピード
	/// </summary>
	public float speed = 5.0f;

    /// <summary>
    /// 横に進むスピード
    /// </summary>
	public float slideSpeed = 2.0f;

	/// <summary>
	/// ジャンプできる回数
	/// </summary>
	public int jumpCount = 2;

	/// <summary>
	/// 設定したジャンプできる回数を保存する変数
	/// </summary>
	int defaultJumpCount;

	//アニメーション
	Animator animator;
	//UIを管理するスクリプト
	UIManager uiscript;
	//上半身のコライダー用
	GameObject headCollider;

	Rigidbody playerRigidbody;




	void Start()
	{
		//変数に必要なデータを格納
		animator = GetComponent<Animator>();
		uiscript = GameObject.Find("Canvas").GetComponent<UIManager>();
		playerRigidbody = GetComponent<Rigidbody>();
		headCollider = GameObject.Find("HeadCollider");

		// 設定したジャンプできる回数を保存
		defaultJumpCount = jumpCount;

	}



	void Update()
	{
		//前に進む
		transform.position += new Vector3(0, 0, speed) * Time.deltaTime;

		//現在のX軸の位置を取得
		float posX = transform.position.x;

		//右アローキーを押した時
		if (Input.GetKey(KeyCode.D))
		{
			if (posX < 1.8f)
			{
				transform.position += new Vector3(slideSpeed, 0, 0) * Time.deltaTime;
			}
		}


		//左アローキーを押した時
		if (Input.GetKey(KeyCode.A))
		{
			if (posX > -1.8f)
			{
				transform.position -= new Vector3(slideSpeed, 0, 0) * Time.deltaTime;
			}
		}

		//アニメーション
		if (Input.GetKeyDown(KeyCode.LeftShift))
        {
			animator.SetBool("Slide", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
			animator.SetBool("Slide", false);
        }


		//現在再生されているアニメーション情報を取得
		var stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		//取得したアニメーションの名前が一致指定ればtrue
		bool isJump = stateInfo.IsName("Base Layer.Jump");
		bool isSlide = stateInfo.IsName("Base Layer.Slide");

        //ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0)
        {
			//速度を初期化
			playerRigidbody.velocity = new Vector3(0, 0, 0);

			//上方向に力を加える
			playerRigidbody.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);

			//ジャンプするアニメーションを再生
			animator.SetTrigger("Jump");

			//残りのジャンプ回数を減らす
			jumpCount--;
        }


		//スライディングしていたら頭の判定をなくす
		if(isSlide == true)
        {
			headCollider.SetActive(false);
        }
        else
        {
			headCollider.SetActive(true);
        }
		

		//落下時のGameOver判定
		

	}

	// Triggerである障害物にぶつかったとき
	void OnTriggerEnter(Collider collider)
	{
		//ゴールした時
		if (collider.gameObject.tag == "Goal")
		{
			//速度を0にして進むのを止める
			speed = 0;

			//横移動する速度を0にして左右移動できなくする
			slideSpeed = 0;

			//ゴールをしたら正面を向くようにする
			Vector3 lockpos = Camera.main.transform.position;
			lockpos.y = transform.position.y;
			transform.LookAt(lockpos);

			//アニメーション
			animator.SetBool("Win", true);

			//UIの表示
			uiscript.Goal();
			
		}
	}


    //Triggerでない障害物にぶつかったとき
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Barrier")
        {

			//速度を0にして進むのを止める
			speed = 0;

			//横移動する速度を0にして左右移動できなくする
			slideSpeed = 0;

			//アニメーション
			animator.SetBool("Dead", true);
			//UIの表示
			uiscript.Gameover();
        }


		if(collision.gameObject.tag == "Ground")
        {
			jumpCount = defaultJumpCount;
        }
    }

}
