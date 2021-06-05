using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject[] dialogue;
    public Monster monster;
    public Innocent[] innocents;

    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogue[counter].SetActive(false);
            ++counter;
            if (counter < dialogue.Length)
            {
                dialogue[counter].SetActive(true);
            } 
            else
            {
                monster.enabled = true;
                foreach(Innocent innocent in innocents)
                {
                    innocent.enabled = true;
                }
                this.gameObject.SetActive(false);
            }
        }
    }
}
