using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    //Privaten Variablen gelten nur für diese Klasse

    Color farbe;
    int anzTueren;
    bool fahren;
    int Maedchen;
    int Jungen;
    string name = "Sefa";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " +
            Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        
        // Wert berechnen

        Maedchen = 5;
        Jungen = 3;

        Debug.Log(Maedchen + Jungen + " Kinder allgemein");



        // Anrede einer Person

        Debug.Log("Hallo " + name);



    }





    // Update is called once per frame
    void Update()
    {

    }
}


