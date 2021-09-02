using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;

    // Start is called before the first frame update
    void Start()
    {
        //define our stack

        Stack stack = new Stack();

        //prepare our data
        int firstPlayerScore = 12;
        int secondPlayerScore = 10;
        int thirdPlayerScore = 100;
        //push a new player score into stack
        stack.Push(firstPlayerScore);
        stack.Push(secondPlayerScore);
        stack.Push(thirdPlayerScore);

        //show information in stack
        ShowInformationInStack(stack);
        //pop player score from stack
        stack.Pop();
        ShowInformationInStack(stack);
        stack.Pop();
        ShowInformationInStack(stack);
    }
    void ShowInformationInStack(Stack stack)
    {
        foreach(var stackitem in stack)
        {
            stackDebug.text += "...............\n";
            stackDebug.text += $"{stackitem}\n";
            print($"{stackitem}\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
