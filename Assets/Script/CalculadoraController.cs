using System;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class CalculadoraController : MonoBehaviour
{

    [SerializeField] private Text TextDisplay1; //String - > Text
    [SerializeField] private Text TextDisplay2;

    private string _expression;

    // Start is called before the first frame update
    void Start()
    {
        TextDisplay1.text = "";
        TextDisplay2.text = "=";
        print("Start");
    }

    /*
    public void Soma(int n1, int n2)
    {
        int r = n1 + n2;
        string f = r.ToString();
        TextDisplay1.text = f;
    }
    */
    
   
    
    public void BtnAC()
    {
        TextDisplay1.text = "";
    }

    public void BtnX()
    {
        string InDisplay = TextDisplay1.text;
        int lengthen =  InDisplay.Length;
        int i = 0;
        string True = "";
        foreach (char Item in InDisplay)
        {
            i++;
            if(i!=lengthen)
            {
                True = True + Char.ToString(Item);
            }
        }
        TextDisplay1.text = True;
    }

    public void BtnParent()
    {
        string InDisplay = TextDisplay1.text;
        string True = "";
        int i = 0;
        int j = 0;
        foreach (char Item in InDisplay)
        {
            True = True + Char.ToString(Item);
            if(Item == '(')
            {
                i++;
            }
            else if(Item == ')')
            {
                j++;
            }
        }
        
        
        if (j>i)
        {
            True = True + "(";
            TextDisplay1.text = True;
        }
        else
        {
            True = True + "(";
            TextDisplay1.text = True;
        }
    }

    public void BtnParentSpecial()
    {
        string InDisplay = TextDisplay1.text;
        string True = "";
        int i = 0;
        int j = 0;
        foreach (char Item in InDisplay)
        {
            True = True + Char.ToString(Item);
            if(Item == '(')
            {
                i=1;
            }
            else
            {
                i=0;
            }
        }
        
        
        if (j>i)
        {
            True = True + "(";
            TextDisplay1.text = True;
        }
        else
        {
            True = True + "(";
            TextDisplay1.text = True;
        }
    }

    public void BtnCharacter(string character)
    {
        string val = character;
        TextDisplay1.text = TextDisplay1.text + val;
        

        /*
        if(val == "")
        {
            x1 = int.Parse(TextDisplay1.text);
            TextDisplay1.text = TextDisplay1.text + val;
        }
        else
        {
            TextDisplay1.text = TextDisplay1.text + val;
        }
        */
    }



    public void ExpressionCalculator()
    {

        _expression = TextDisplay1.text;
        DataTable table = new DataTable("tabela");
        string _result = table.Compute(_expression, string.Empty).ToString();
        print("Verificar: "+table);
        //print(Mathf.Pow(3,4)Mathf.Exp(1));
        TextDisplay2.text = "=" + _result;
    }

    
    
    

}
