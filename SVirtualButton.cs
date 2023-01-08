using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SVirtualButton : MonoBehaviour
{ 
public GameObject vbBtnObject; // обєкт для кнопки
public Animator animObject;
        void Start()        {
        vbBtnObject = GameObject.Find("VirtualButton");
        vbBtnObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        animObject.GetComponent<Animator>();
        }
        // задаєм дію  кнопки в нажатому стані:
        public void OnButtonPressed(VirtualButtonBehaviour vb)        {
        // включаємо анимацію з назвою "object_animation"
        animObject.Play("Object_animation");
        Debug.Log("Ура, працює!");
        }
        // задаєм дію кнопки коли не натиснена:
        public void OnButtonReleased(VirtualButtonBehaviour vb)        {
            animObject.Play("none");
            Debug.Log("кнопку відпустили!");
        }
}

