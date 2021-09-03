using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    //public GameObject Cube;
    //public GameObject Sphere;
    //public GameObject Capsule;
    //public GameObject cylinder;
    int test=0;
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        //define our stack

        Queue queue = new Queue();


        //prepare our data
        /* int firstPlayerScore = 12;
         int secondPlayerScore = 10;
         int thirdPlayerScore = 100;
         //push a new player score into stack
         queue.Enqueue(firstPlayerScore);
         queue.Enqueue(secondPlayerScore);
         queue.Enqueue(thirdPlayerScore);*/
        for (int i = 0; i < prefabs.Length; i++)
        {
            queue.Enqueue(prefabs[i]);
        }
        

        //show information in stack
        
        ShowInformationInStack(queue);
        //pop player score from stack
        queue.Dequeue();
        ShowInformationInStack(queue);
        queue.Dequeue();
        ShowInformationInStack(queue);
    }
    void ShowInformationInStack(Queue queue)
    {
        foreach (GameObject queueitem in queue)
        {
           
            stackDebug.text += "...............\n";
            stackDebug.text += $"{queueitem}\n";

            Instantiate(queueitem, transform.position+new Vector3(0,test,0),Quaternion.identity) ;
            test = test + 2;
            print($"{queueitem}\n");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
