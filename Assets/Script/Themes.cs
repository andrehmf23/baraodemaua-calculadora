using UnityEngine;
using UnityEngine.UI;


public class Themes : MonoBehaviour
{
    //Colors Buttons
    [SerializeField] private UnityEngine.Color ButtonGray = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color ButtonGrayLight = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color ButtonBlueBlack = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color ButtonBlue = new UnityEngine.Color();

    //Colors Text
    [SerializeField] private UnityEngine.Color TextBlue1 = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color TextBlue2 = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color TextEqual = new UnityEngine.Color();
    [SerializeField] private UnityEngine.Color TextEsc = new UnityEngine.Color();

    //Color background
    [SerializeField] private UnityEngine.Color blackBackground = UnityEngine.Color.black;
    [SerializeField] private UnityEngine.Color whiteBackground = UnityEngine.Color.white;

    //UI Componentes
    [SerializeField] private Text[] fontTextNumbers;
    [SerializeField] private Text[] fontTextSpecial;
    [SerializeField] private Text[] fontTextSinals;
    [SerializeField] private Text[] fontTextEqual;
    [SerializeField] private Text[] fontTextEsc;
    [SerializeField] private Button[] fontButtonsNumbersAndSpecial;
    [SerializeField] private Button[] fontButtonEsc;
    [SerializeField] private Button[] fontButtonsSinals;
    [SerializeField] private Button[] fontButtonsEqual;
    [SerializeField] private Camera myCamera;


    // Start is called before the first frame update
    void Start()
    {
        ChoiceBlackColor();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChoiceColor()
    {
        if (myCamera.backgroundColor == blackBackground)
        {
            ChoiceWhiteColor();
        }
        else
        {
            ChoiceBlackColor();
        }
    }

    public void ChoiceBlackColor()
    {
        myCamera.backgroundColor = blackBackground;

        //Text
        for (int i = 0; i < 12; i++)
        {
            fontTextNumbers[i].color = TextBlue1;
            fontTextNumbers[i].resizeTextMaxSize = 70;
            fontTextNumbers[i].fontStyle = FontStyle.Bold;
        }

        for (int i = 0; i < 4; i++)
        {
            fontTextSpecial[i].color = TextBlue1;
            fontTextSpecial[i].resizeTextMaxSize = 60;
            fontTextSpecial[i].fontStyle = FontStyle.Bold;
        }

        for (int i = 0; i < 4; i++)
        {
            fontTextSinals[i].color = TextBlue2;
            fontTextSinals[i].resizeTextMaxSize = 70;
            fontTextSinals[i].fontStyle = FontStyle.Bold;
        }

        for (int i = 0; i < 1; i++)
        {
            fontTextEqual[i].color = TextEqual;
            fontTextEqual[i].resizeTextMaxSize = 70;
            fontTextEqual[i].fontStyle = FontStyle.Bold;
        }

        for (int i = 0; i < 3; i++)
        {
            fontTextEsc[i].color = TextEsc;
            fontTextEsc[i].resizeTextMaxSize = 70;
            fontTextEsc[i].fontStyle = FontStyle.Bold;
        }


        //Button
        for (int i = 0; i < 16; i++)
        {
            fontButtonsNumbersAndSpecial[i].image.color = ButtonGray;
        }

        for (int i = 0; i < 3; i++)
        {
            fontButtonEsc[i].image.color = ButtonGrayLight;
        }

        for (int i = 0; i < 4; i++)
        {
            fontButtonsSinals[i].image.color = ButtonBlueBlack;
        }

        for (int i = 0; i < 1; i++)
        {
            fontButtonsEqual[i].image.color = ButtonBlue;
        }
    }

    public void ChoiceWhiteColor()
    {
        myCamera.backgroundColor = whiteBackground;
        for (int i = 0; i < 26; i++)
        {
            fontTextNumbers[i].color = blackBackground;
        }
    }

}
