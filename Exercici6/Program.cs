using System;

namespace ProjecteProva2
{
    public class Exercici6
    {
        /*La contrasenya màgica ha de complir les següents restriccions:
    Ha de tenir entre 6 i 15 caràcters (inclosos).
    Només pot contenir lletres i números (a-z, A-Z, 0-9).
    No pot començar ni acabar amb un número.*/

        const int MinNum = 0;
        const int MaxNum = 9;

        const int MaxLenght = 15;
        const int MinLenght = 6;
        const string ErrNombre = "Malament, escomença o acaba per un nombre!";
        const string ErrFormat = "Conté caràcters que no son lletres de la a a la z, o nombres";

        public static bool ValidaContrasenya(string contrasenya)
        {
            bool correcte = false;

            if (contrasenya.Length > MaxLenght - 1 && contrasenya.Length < MinLenght)
            {
                for (int i = 0; i < contrasenya.Length; i++)
                {
                    if((contrasenya[i] < 'a' && contrasenya[i] > 'z')  || (contrasenya[i] < 'A' && contrasenya[i] > 'Z'))
                    {
                        correcte = false;
                        i = contrasenya.Length;
                    }
                }
            }
            return correcte;

            //volia extreure mètodes de comparacions, el de assignar el estat, i modularitzar més
        }
    }
}