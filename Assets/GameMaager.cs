using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public GameObject[] imgList;
	public int imgAnswer;
	public int[] imgOptions;
	public Transform parent;
	bool answerExists = true;
	
	void Start () {
		imgList = Resources.LoadAll<GameObject> ("Prefabs");
		imgAnswer = Random.Range (0, 4);
		Debug.Log (imgList[imgAnswer]);
		parent = GameObject.Find("Canvas").transform;
	}
	
	void imgDraw () {
		GameObject answer = Instantiate (imgList [imgAnswer]);
		answer.transform.SetParent (parent ,false);
		answer.transform.position = new Vector3 (0,0,0);
		answerExists = false;
	}
	
	void Update () {
		if (answerExists)
			imgDraw ();
	}
}