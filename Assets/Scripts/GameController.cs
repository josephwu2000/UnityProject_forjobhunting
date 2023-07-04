using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour 
{
	public Scene nextScene;

	public int L1_enemy = 6;
	public int L2_enemy = 6;
	public Text enemyText;

	public float timer = 16f;
	public Text timerText;

	public bool countStart = false;

	public bool resetStart = false;
	public Text infoText;
	public float resetTimer = 3f;

	void Update () 
	{
		if(countStart == true)
		{
			timer -= Time.deltaTime;
			timerText.text = "TIME : " + timer.ToString("0"); 
			enemyText.text = "剩下：" + L1_enemy;
		}

		if(timer < 0f)
		{
			countStart = false;
			timer = 15f;
			resetStart = true;
		}

		if(resetStart == true)
		{
			resetTimer -= Time.deltaTime;
			infoText.text = "挑戰失敗！關卡將在" + resetTimer.ToString("0") + "秒後重啟。"; 			
			enemyText.text = "";
		}

		if(resetTimer < 0)
		{
			resetStart = false;
			resetTimer = 3f;
			L1_enemy = 6;
			L2_enemy = 6;
			Debug.Log("resetStart");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		if(L1_enemy == 0 || L2_enemy == 0)
		{
			countStart = false;
			resetTimer -= Time.deltaTime;
			infoText.text = "挑戰成功！將在" + resetTimer.ToString("0") + "秒後進入下一關。";
			if(resetTimer < 0)
			{
			    SceneManager.LoadScene("Level2");
			}
		}
	}

	float countDown(float number)
	{
		number -= Time.deltaTime;
		return number;
	}
}
