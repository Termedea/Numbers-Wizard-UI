using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;

public class NumbersWizard : MonoBehaviour {
	private int _max;	
	private int _min; 
	private int _guess;
    private int _maxGuessesAllowed;

    public Text _text;
	
	// Use this for initialization
	private void Start () {
		
		StartGame();
	}
	

    public void GuessHigher()
    {
        _min = _guess;
        NextGuess();
    }

    public void GuessLower()
    {
        _max = _guess;
        NextGuess();
    }

    private void StartGame(){
        _max = 1001;
        _min = 1;
        _maxGuessesAllowed = 10;
        NextGuess();
	}
	
	private void NextGuess(){
			
		_guess = Random.Range(_min, _max);
        _text.text = _guess.ToString();

        _maxGuessesAllowed--;

        if(_maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }

	}
}
