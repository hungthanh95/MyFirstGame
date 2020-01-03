using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMagic : MonoBehaviour
{
	int maxNumber = 1000;
	int minNumber = 1;
	int guessNumber = 500;
	// Start is called before the first frame update
	void Start()
    {
		Debug.Log("Welcome to Magic Number!!!!!!!!!!!!");
		Debug.Log("Please pick up your numbers, don't tell me what is it....");
		Debug.Log("The highest number you can pick is: " + maxNumber);
		Debug.Log("The lowest number you can pick is: " + minNumber);
		Debug.Log("Tell me you pick number higher or lower than 500.");
		Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
		maxNumber = maxNumber + 1;
	}
	int CalGuessNum(int min, int max)
	{
		return (int)((min + max) / 2);
	}
	void LetGuess(ref int num)
	{
		num = guessNumber;
		guessNumber = CalGuessNum(minNumber, maxNumber);
		Debug.Log("Your guess number is " + guessNumber);
	}
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Up Arrow key was pressed.");
			LetGuess(ref minNumber);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("Down Arrow key was pressed.");
			LetGuess(ref maxNumber);
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("The guess number is correct.");
		}

	}
}
