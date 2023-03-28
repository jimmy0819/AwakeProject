using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class DialogueSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset InkJSONAsset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Story exampleStory = new Story(InkJSONAsset.text);
        Debug.Log(exampleStory.ContinueMaximally());
        while(exampleStory.canContinue)
        {
            // Load the next story chunk and return the current text
            string currentTextChunk = exampleStory.ContinueMaximally();

            // Show the current story text in the Console window
            Debug.Log(currentTextChunk);
            Debug.Log( exampleStory.currentChoices.Count.ToString());
            // Iterate through the current choices
            // For each choice in currentChoice, set its values to the new variable 'choice'
            foreach (Choice choice in exampleStory.currentChoices)
            {
                // Show choice's text
                Debug.Log(choice.text);

                // Show choice's index
                Debug.Log(choice.index);
            }

            // Pick the first (0) choice based on its index in the currentChoices List<Choice>
            exampleStory.ChooseChoiceIndex(0);

        }
    }
}
