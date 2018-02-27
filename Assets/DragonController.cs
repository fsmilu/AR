using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DragonController : MonoBehaviour
{
    GameObject dragon;

    void Start()
    {
        if (GameObject.Find("1"))
        {
            dragon = GameObject.Find("1");
        }
    }

    public void RotateDragon()
    {
        GameObject.Find("DebugText").GetComponent<Text>().text = "Let's Rotate";
        dragon.GetComponent<Roate1>().enabled = true;
        dragon.GetComponent<Lean.Touch.LeanTranslate>().enabled = false;
    }

    public void MoveDragon()
    {
        GameObject.Find("DebugText").GetComponent<Text>().text = "Let's Move";
        dragon.GetComponent<Roate1>().enabled = false;
        dragon.GetComponent<Lean.Touch.LeanTranslate>().enabled = true;
    }
}
