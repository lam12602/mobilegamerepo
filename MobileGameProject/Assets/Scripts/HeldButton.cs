using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//This means that this script can only be attached to a buttoned component
[RequireComponent(typeof(Button))]

//The additional items in this list let us respond to mouse or touch events
public class HeldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    //we will store our button here so we can use it 
    private Button button;

    //use thisn to track if button is pressed
    private bool buttonPressed = false;


    public void OnPointerDown(PointerEventData eventData)
    {
        //ignore if button is not interactable
        if (!button.interactable) return;
      
        //record that the button is being pressed
        buttonPressed = true;
    }

    //called when user takes pointer or finger off button while mouse down
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    // Awake is called before anything else
    void Awake()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //if we recorded that the button is being pressed
        if (buttonPressed)
        {
            //call the onclick function set up in unity
            button.onClick?.Invoke();
        }
    }
}
