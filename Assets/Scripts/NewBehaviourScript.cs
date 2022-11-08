using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Image _image;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            float r = Random.Range(0.0f, 1.0f);
            Color c = new Color(r, r, r);
            _image.color = c;
        }
    }
}
