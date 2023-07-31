using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTextScript : MonoBehaviour
{
    //[SerializeField]
    //private GameObject canvas;

    [SerializeField]
    private GameObject text;

    //[SerializeField] Portal portal;

    //[SerializeField] PortalTrigger crystal;

    [SerializeField]
    private Collider2D textTrigger;

    private bool textAppeared;


    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        textAppeared = false;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !textAppeared)
        {
            text.SetActive(true);
            
        }
        //else if (collision.CompareTag("Player") && !textTrigger.CompareTag("Trigger2") && !textAppeared)
        //{
        //    text.SetActive(true);
            

        //}
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
        textAppeared = true;
    }

  
}
