using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPressed;

    public GameObject hiteffect, goodeffect, perfecteffect, misseffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPressed)){
            if (canBePressed)
            {
                gameObject.SetActive(false);

                //GameManager.instance.NoteHit();

                if(Mathf.Abs(transform.position.y) >= 103.0f)
                {
                    Debug.Log("Hit");
                    GameManager.instance.NormalHit();
                    Instantiate(hiteffect, transform.position, hiteffect.transform.rotation);
                }
                else if(Mathf.Abs(transform.position.y) >= 60.0f)
                {
                    Debug.Log("Good");
                    GameManager.instance.GoodHit();
                    Instantiate(goodeffect, transform.position, goodeffect.transform.rotation);
                } else if (Mathf.Abs(transform.position.y) >= 41.0f)
                {
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfecteffect, transform.position, perfecteffect.transform.rotation);
                }else
                {
                    Debug.Log("Miss");
                    GameManager.instance.NoteMissed();
                    Instantiate(misseffect, transform.position, misseffect.transform.rotation);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator") {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
