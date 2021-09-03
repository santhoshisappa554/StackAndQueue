using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    int test = 0;
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        //define our stack

        Stack stack = new Stack();

        //prepare our data
        /*int firstPlayerScore = 12;
        int secondPlayerScore = 10;
        int thirdPlayerScore = 100;*/
        //push a new player score into stack
        for (int i = 0; i < prefabs.Length; i++)
        {
            stack.Push(prefabs[i]);
        }
       
        /*stack.Push(prefabs[1]);
        stack.Push(prefabs[2]);
        stack.Push(prefabs[3]);*/

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
        foreach(GameObject stackitem in stack)
        {
            stackDebug.text += "...............\n";
            stackDebug.text += $"{stackitem}\n";
            Instantiate(stackitem, transform.position + new Vector3(0, test, 0), Quaternion.identity);
            test = test + 2;
            print($"{stackitem}\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
