
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{

    [SerializeField] private Text TextCar;
    [SerializeField] private Text TextPlate;
    [SerializeField] private Text TextAge;
    [SerializeField] private Text TextDisplay;

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetString("name","André HMF");
        // PlayerPrefs.SetInt("idade",19);
        // PlayerPrefs.SetFloat("altura",1.88f);

        // string name = PlayerPrefs.GetString("name");
        // int idade = PlayerPrefs.GetInt("idade");
        // float altura = PlayerPrefs.GetFloat("altura");

        // Debug.Log("Informação debug: N:"+ name +" I:"+idade+" A:"+altura);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnSave()
    {
        string Car = TextCar.text;
        string Plate = TextPlate.text;
        string Age = TextAge.text;

        PlayerPrefs.SetString("car",Car);
        PlayerPrefs.SetString("plate",Plate);
        PlayerPrefs.SetString("age",Age);
    }

    public void BtnView()
    {
        string car = PlayerPrefs.GetString("car");
        string plate = PlayerPrefs.GetString("plate");
        string age = PlayerPrefs.GetString("age");

        string inf;

        switch (plate)
        {
            case "V56-7920":

            inf = "Permitida";

            break;
            default:

            inf = "Não permitida";

            break;
        }

        TextDisplay.text = "Carro: "+ car + " Placa: "+ plate +" Ano: "+ age + " Circulação: " + inf;
    }
}