using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private Text TextDisplay1; //String - > Text
    [SerializeField] private Text TextDisplay2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sum()
    {
        Debug.Log("teste");
    }
    public void Somaa(float n3, float n4)
    {
        int n1 = 5;
        int n2 = 10;
        int r = n1 + n2;
        string f = r.ToString();
        TextDisplay1.text = f;
    }
}
