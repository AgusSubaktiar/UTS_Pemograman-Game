using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapObjek : MonoBehaviour
{
    public GameObject bola;
    public GameObject tangan;

    bool tertangkap = false;

    Vector3 posisiBola;
    // Start is called before the first frame update
    void Start()
    {
        posisiBola = bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(0f, -0.100f, 1.48f);   
                tertangkap = true;
                bola.GetComponent<Renderer>().material.color = Color.blue;
                TextMesh hitam = GameObject.Find("Text").GetComponent<TextMesh>();
                hitam.text = "Bola ditangkap";
            }
            else if (tertangkap)
            {
                TextMesh hitam = GameObject.Find("Text").GetComponent<TextMesh>();
                hitam.text = "Bola dilepas";
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                tertangkap = false;
                bola.GetComponent<Renderer>().material.color = Color.red;
            }
            
        }
    }
}
