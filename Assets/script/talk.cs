using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class talk : MonoBehaviour {
	public static Flowchart flowchartManger;
	public Flowchart talkFlowchart;
	public string onCollosionEnter;
	public string onMouseDown="mousetouch";
	Rigidbody playerRigidbody;

	// Use this for initialization
	void Awake() {
		flowchartManger = GameObject.Find ("對話管理器").GetComponent<Flowchart> ();
		playerRigidbody = FindObjectOfType<player>().GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static bool isTalking{
		get{ return flowchartManger.GetBooleanVariable ("對話中");}
	}

	void PlayBlock(string targetBlockName)
	{
		Block targetblock = talkFlowchart.FindBlock (targetBlockName);
		if (targetblock != null) {
			talkFlowchart.ExecuteBlock (targetblock);
		} else {
			Debug.LogError ("找不到在 " + talkFlowchart.name + "裡的" + targetBlockName + "Block");
			
		}
		talkFlowchart.ExecuteBlock (targetBlockName);
	}

	private void OnCollisionEnter(Collision other)//如果有其他物件碰到這個的話
	{
		if(!string.IsNullOrEmpty(onCollosionEnter) && !isTalking)
		{
			if (other.gameObject.CompareTag ("player")) //玩家標籤是player的時候
			{
				playerRigidbody.Sleep ();
				PlayBlock (onCollosionEnter);
			}		
		}

	}
	private void OnMouseDown()
	{
		if(!string.IsNullOrEmpty(onMouseDown) && !isTalking)
		{
			playerRigidbody.Sleep ();
			PlayBlock (onMouseDown);
		}

	}

}
