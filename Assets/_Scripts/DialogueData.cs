using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DialogueData : MonoBehaviour {
	public Text _textComponent;

	public string[] DialogueStrings;

	//private float SecondsBetweenCharacters = 0.01f;
	//private float CharacterRateMultiplier = 0.001f;

	public KeyCode DialogueInput = KeyCode.Mouse0;

	//private bool _isStringBeingRevealed = false;
	//private bool _isDialoguePlaying = false;
	private bool _isEndOfDialogue = false;
	private bool _isDialogueActive = true;
	public GameObject Choices;


	public GameObject char1;
	public Sprite[] character1;
	public GameObject char2;
	public Sprite[] character2;
	public GameObject char3;
	public Sprite[] character3;
	public GameObject char4;
	public Sprite[] character4;

	private int currentDialogueLine;

	// Use this for initialization
	void Start () {
		_textComponent = GetComponent<Text> ();
		_textComponent.text = "";


	}

	// Update is called once per frame
	void Update ()
	{
		if (_isDialogueActive && Input.GetKeyDown(KeyCode.Mouse0)) { 
			currentDialogueLine++;
		}
		if (currentDialogueLine >= DialogueStrings.Length) {
			_isEndOfDialogue = true;
			ShowChoices ();
			currentDialogueLine = 0;

		}
		_textComponent.text = DialogueStrings [currentDialogueLine];
		char1.GetComponent<SpriteRenderer>().sprite = character1[currentDialogueLine];
		char2.GetComponent<SpriteRenderer>().sprite = character2[currentDialogueLine];
		char3.GetComponent<SpriteRenderer>().sprite = character3[currentDialogueLine];
		char4.GetComponent<SpriteRenderer>().sprite = character4[currentDialogueLine];
	}

	private void ShowChoices ()
	{
		if (_isEndOfDialogue == true) {
			Choices.SetActive (true);
		}
	}
}

		//	char1.GetComponent<SpriteRenderer>().sprite = character1[currentDialogueIndex];









	//{
	//	if (!_isEndOfDialogue) {
	//		if (!_isDialoguePlaying) {
	//			_isDialoguePlaying = true;
	//			StartCoroutine (StartDialogue ());
	//		}
	//	}

	//}

	//public IEnumerator StartDialogue()
	//{
	//	int dialogueLength = DialogueStrings.Length;
	//	int currentDialogueIndex = 0;


	//	while (currentDialogueIndex < dialogueLength || !_isStringBeingRevealed){
	//		if (!_isStringBeingRevealed){
	//			_isStringBeingRevealed = true;
	//			StartCoroutine (DisplayString (DialogueStrings [currentDialogueIndex++]));
	//			if (currentDialogueIndex >= dialogueLength){
	//				_isEndOfDialogue = true;
	//			}
	//		}
	//		yield return 0;
	//	}
			
	//	_isDialoguePlaying = false;
	//}
		

	//public IEnumerator DisplayString(string stringToDisplay){
	//	int stringLength = stringToDisplay.Length;
	//	int currentCharacterIndex = 0;
	//
	//	_textComponent.text = "";
	//
	//	while (currentCharacterIndex < stringLength) {
	//
	//			_textComponent.text += stringToDisplay [currentCharacterIndex];
	//			currentCharacterIndex++;
	//
	//
	//		if (currentCharacterIndex < stringLength) {
	//			if (Input.GetKey (DialogueInput)) {
	//				yield return new WaitForSeconds (SecondsBetweenCharacters * CharacterRateMultiplier);
	//			} else {
	//				yield return new WaitForSeconds (SecondsBetweenCharacters);
	//			}
	//		} else {
	//			break;
	//		}
	//	}
	//	ShowChoices();
	//
	//	while (true) {
	//		if (Input.GetKeyDown (DialogueInput)) {
	//			break;
	//		}
	//		yield return 0;
	//	}
	//
	//	_isStringBeingRevealed = false;
	//	_textComponent.text = "";
	//}


	//private void ShowChoices(){
	//	if (_isEndOfDialogue == true) {
	//		Choices.SetActive (true);
	//
	//		return;
	//	}

	//}
//}
