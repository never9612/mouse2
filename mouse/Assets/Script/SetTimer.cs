﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour {

	private float totalTime;
	private int minute;
	private float second;
	private float timeCounter;
	private int oldSecond;
	//private bool timerFlag = true;
	private Text textField;

	// Use this for initialization
	void Start () {
		minute = 1;
		second = 2f;
		totalTime = minute * 60 + second;
		timeCounter = 60;
		oldSecond = 0;
		textField = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Time.timeScale > 0 && totalTime > 0f) {
			totalTime = minute * 60 + second;
			totalTime -= Time.deltaTime;

			minute = (int)(totalTime / 60);
			second = totalTime - minute * 60;
			if ((int)second != oldSecond) {
				textField.text = minute.ToString ("00") + ":" + second.ToString ("00");
			}
			oldSecond = (int)second;

			if (totalTime <= 0f) {
				Debug.Log ("制限時間終了");
			}
		}
		*/
		timeCounter -= Time.deltaTime;

		timeCounter = Mathf.Max (timeCounter, 0.0f);
		textField.text = ((int)timeCounter).ToString ();
	}
}
