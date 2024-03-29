﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class UiManager : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _timeText;
	[SerializeField]
	private TextMeshProUGUI _levelNum;
	[SerializeField]
	private TextMeshProUGUI _deathCount;
	
	double secsRound;
	string strSecs;
	double miliRound;
	string strMili;
	
    // Start is called before the first frame update
    void Start()
    {
	    _timeText.text = "0";
    }

    // Update is called once per frame
	void Update()
	{
		secsRound = Mathf.RoundToInt((float)Player.seconds);
		if (secsRound <= 9)
		{
			strSecs = 0 + secsRound.ToString();
		}
		else
		{
			strSecs = secsRound.ToString();
		}
		
		miliRound = Mathf.RoundToInt((float)Player.miliSecs);
		
		if (miliRound <= 10)
		{
			strMili = "000";
		}
		else if (miliRound <= 99)
		{
			strMili = "0" + miliRound.ToString();
		}
		else
		{
			strMili = miliRound.ToString();
		}
		
		_timeText.text = Player.minutes + ":" + strSecs + ":" +  strMili;
		
		_levelNum.text = "Level: " + (SceneManager.GetActiveScene().buildIndex - 5);
		
		_deathCount.text = "Deaths: " + Player.deaths;
	}
    
	public static void left()
	{
		Player.tryLeft = true;
	}
	public static void right()
	{
		Player.tryRight = true;
	}
	public static void jump()
	{
		Player.tryJump = true;
	}
	public static void reset()
	{
		Player.reset = true;
	}
	public static void hardReset()
	{
		Player.hardReset = true;
	}
}
