using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public AnimationCurve showCurve;
    public AnimationCurve hideCurve;
    public float animationSpeed;
    public GameObject panel;
    bool istwice = false;
   // public Image image;

    
    IEnumerator ShowPanel(GameObject gameObject)
    {
        float timer = 0;
        while (timer <= 1)
        {
            //yield return new WaitForSeconds(0.001f);
            gameObject.transform.localScale = Vector3.one * showCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }


    IEnumerator HidePanel(GameObject gameObject)
    {
        float timer = 0;
        while (timer <= 1)
        {
            gameObject.transform.localScale = Vector3.one * hideCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }



    /*private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.name=="Capsule")
                {
                    // image.gameObject.SetActive(true);
                    StartCoroutine(ShowPanel(panel));
                }
            }
        }
        else if(Input.GetMouseButtonDown(1))
        {
           
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Capsule")
                    {
                        // image.gameObject.SetActive(true);
                        StartCoroutine(HidePanel(panel));
                    }
                }
            
               
        }


        
    }*/

    private void Update()
    {
        if(!istwice)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Capsule")
                    {
                        // image.gameObject.SetActive(true);
                        StartCoroutine(ShowPanel(panel));
                        print(istwice);
                        istwice = !istwice;
                    }
                }

            }
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Capsule")
                    {
                        // image.gameObject.SetActive(true);
                        StartCoroutine(HidePanel(panel));
                        print(istwice);
                        istwice = !istwice;
                    }
                }


            }
       
        }

        //istwice = !istwice;
        
    }
}
