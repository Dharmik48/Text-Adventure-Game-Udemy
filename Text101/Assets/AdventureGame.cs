using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to access properties from UI component

public class AdventureGame : MonoBehaviour
{
  [SerializeField] Text textComponent; // [SerializeField] - To make this variable visible in unity as a component
                                       // Creates a variable of type 'Text' which comes from the UI Object of Unity

  // Start is called before the first frame update
  void Start()
  {
    textComponent.text = ("Welcome to \"The Pass to Eldelvain\" "); //Access the 'text' property of textComponent
  }

  // Update is called once per frame
  void Update()
  {

  }
}
