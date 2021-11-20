using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to access properties from UI component

public class AdventureGame : MonoBehaviour
{
  [SerializeField] Text textComponent; // [SerializeField] - To make this variable visible in unity as a component
                                       // Creates a variable of type 'Text' which comes from the UI Object of Unity
  [SerializeField] State startingStory;
  State currentState;

  // Start is called before the first frame update
  void Start()
  {
    currentState = startingStory;
    textComponent.text = currentState.GetStateStory(); //Access the 'text' property of textComponent
  }

  // Update is called once per frame
  void Update()
  {
    ManageState();
  }

  private void ManageState()
  {
    var nextStates = currentState.GetNextStates();

    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      currentState = nextStates[0];
    }
    else if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      currentState = nextStates[1];
    }
    else if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      currentState = nextStates[2];
    }



    textComponent.text = currentState.GetStateStory();
  }
}
