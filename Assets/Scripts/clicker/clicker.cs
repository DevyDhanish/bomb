using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicker : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private buttons button;
    private void Start()
    {
    }
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform)
                {
                    button = hit.transform.gameObject.GetComponent<buttons>();
                    switch (hit.transform.tag)
                    {
                        case "1":
                            button.one();
                            break;
                        case "2":
                            button.two();
                            break;
                        case "3":
                            button.three();
                            break;
                        case "4":
                            button.four();
                            break;
                        case "5":
                            button.five();
                            break;
                        case "6":
                            button.six();
                            break;
                        case "7":
                            button.seven();
                            break;
                        case "8":
                            button.eight();
                            break;
                        case "9":
                            button.nine();
                            break;
                        case "0":
                            button.zero();
                            break;
                        case "*":
                            button.Star();
                            break;
                        case "#":
                            button.hash();
                            break;
                        case "clear":
                            button.clear();
                            break;
                        case "rig":
                            button.rig();
                            break;
                        default:
                            Debug.Log("Unknow button");
                            break;
                    }
                }
            }
        }
    }
}
