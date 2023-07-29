using System;
using System.IO;
//using System.Security.Cryptography;

namespace EinfacheVerschluesselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Verschluesseln.Auswahl();

            //Caesar-Verschlüssselung:
            //a = 1, b = 2, c = 3,... (Alternative a = 0, b = 1, c = 2)
            //Verschiebung +2
            //Ausganstext: "Hallo"
            //Verschlüsselt: "Jcnnq"
            //Entschlüsselt: Vorgang Rückgängig

            //Programm:
            //Anwender gibt Schlüssel ein (z.B. +2 oder -3, etc)
            //Soll eine Text-Datei einlesen
            //Der Inhalt soll verschlüsselt werden (mit Hilfe des eingegeben Schlüssels)
            //Eine neue Text-Datei soll ausgegeben werden mit dem verschlüsselten Inhalt
            // a) Großbuchstaben
            // b) Leer- und Satzzeichen
            // c) Mit mehreren Zeilen?

            //Vigniere-Verschlüsselung
            //Schlüssel: string, z.B. "Key" => K(42) e(4) y(24)
            //Anhand der KeyListe wird das Schlüsselwort in Zahlen umgerechnet
            //Das 1. Zeichen wird mit der ersten Zahl des Schlüssels verschlüssert
            //Das 2. Zeichen wird mit der zweiten Zahl des Schlüssels verschlüssert
            //etc...
        }
    }
}
