using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    
    public Dialogue dialogueArchive; //the scriptable objects

    bool isTalking = false;

    float distance; // the distance of the NPC from the player which could triger the dialogue
    float currentResponseTracker = 0f; // to organize which response the npc is needed to generate based off of our player dialogue



    public GameObject player;
    public GameObject dialogueUI;

    //public TextMeshProUGUI npcName;
    public TextMeshProUGUI dialogueBox;
    //public TextMeshProUGUI playerResponse;
    public GameObject continueButton;




    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame

    private void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if(distance <= 6f)
        {
            //trigger dialogue
            if(Input.GetKeyDown(KeyCode.E) && isTalking == false)
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
            {
                EndDialogue();
            }
        }
    }

    public void StartConversation()
    {
        isTalking = true;
        currentResponseTracker = 0;
        dialogueUI.SetActive(true);
        dialogueBox.text = dialogueArchive.dialogue[0];
        continueButton.SetActive(true);
    }

    void EndDialogue()
    {
        isTalking = false;
        continueButton.SetActive(false);
        dialogueUI.SetActive(false);

    }
    
    
}
