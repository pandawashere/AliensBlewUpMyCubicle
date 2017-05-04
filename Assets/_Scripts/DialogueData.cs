﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueData : MonoBehaviour {
	public Text _textComponent;

	public string[] DialogueStrings;

	public float SecondsBetweenCharacters = 0.5f;
	public float CharacterRateMultiplier = 0.75f;

	public KeyCode DialogueInput = KeyCode.Return;

	private bool _isStringBeingRevealed = false;
	private bool _isDialoguePlaying = false;
	private bool _isEndOfDialogue = false;

	public GameObject Choices;


	// Use this for initialization
	void Start () {
		_textComponent = GetComponent<Text> ();
		_textComponent.text = "";


	}

	// Update is called once per frame
	void Update () {
		if (!_isEndOfDialogue) {
			if (!_isDialoguePlaying) {
				_isDialoguePlaying = true;
				StartCoroutine (StartDialogue ());
			}
		}

	}

	private IEnumerator StartDialogue()
	{
		int dialogueLength = DialogueStrings.Length;
		int currentDialogueIndex = 0;

		while (currentDialogueIndex < dialogueLength || !_isStringBeingRevealed){
			if (!_isStringBeingRevealed){
				_isStringBeingRevealed = true;
				StartCoroutine (DisplayString (DialogueStrings [currentDialogueIndex++]));
				if (currentDialogueIndex >= dialogueLength){
					_isEndOfDialogue = true;
				}
			}
			yield return 0;
		}
			
		_isDialoguePlaying = false;
	}


	private IEnumerator DisplayString(string stringToDisplay){
		int stringLength = stringToDisplay.Length;
		int currentCharacterIndex = 0;



		_textComponent.text = "";

		while (currentCharacterIndex < stringLength) {

			_textComponent.text += stringToDisplay [currentCharacterIndex];
			currentCharacterIndex++;

			if (currentCharacterIndex < stringLength) {
				if (Input.GetKey (DialogueInput)) {
					yield return new WaitForSeconds (SecondsBetweenCharacters * CharacterRateMultiplier);
				} else {

					yield return new WaitForSeconds (SecondsBetweenCharacters);
				}
			} else {
				break;
			}
		}
		ShowIcon();

		while (true) {
			if (Input.GetKeyDown (DialogueInput)) {
				break;
			}
			yield return 0;
		}

		_isStringBeingRevealed = false;
		_textComponent.text = "";
	}


	private void ShowIcon(){
		if (_isEndOfDialogue == true) {
			Choices.SetActive (true);





			return;
		}

	}
}
