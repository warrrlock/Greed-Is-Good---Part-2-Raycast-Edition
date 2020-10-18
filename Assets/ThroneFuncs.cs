using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroneFuncs : MonoBehaviour
{
    public GameObject Ray_Rotate;

    public static bool ChairChange = false;
    public Sprite ChairSit;

    // Start is called before the first frame update
    void Start()
    {
        Ray_Rotate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ChairChange == true) {
            gameObject.GetComponent<SpriteRenderer>().sprite = ChairSit;
            Ray_Rotate.SetActive(true);
        }
    }
}
