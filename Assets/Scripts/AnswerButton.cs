using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {


    public Text answerText;

    private  AnswerData answerData;
    private GameConroller gameController;

	// Use this for initialization
	void Start () {

        gameController = FindObjectOfType<GameConroller>(); 
	}

    public void Setup (AnswerData data){

        answerData = data;
        answerText.text = answerData.answerText; 

    }

    public void HandleClick(){

        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
