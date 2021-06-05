using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogue;
    public Monster monster;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("entered dialogue trigger");
        dialogue.SetActive(true);
        monster.enabled = false;
        this.gameObject.SetActive(false);
    }
}
