using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Piwowarski62024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej pomocniczej dla przechowania 'kodu' naciśniętego klawisza
            ConsoleKeyInfo WybranaFunkcjonalność;
            // dla wielokrotnego pwoatarzania obliczeń stosujemy intrukcję do - while
            do
            {
                // reset kolorów menu
                Console.ResetColor();
                // wyczyszczenie okna konsoli
                Console.Clear();
                // wypisanie Metryki projektu Nr1
                Console.WriteLine("\n\n\t\tProgram ProjektNr1_Piwowarski62024 " +
                    "umożliwia obliczanie wybranych wielkości matematycznych");
                // wypisanie Menu programu
                Console.WriteLine("\n\tMenu programu");
                Console.WriteLine("\n\tA. Laboratorium Nr 1: Kalkulator obliczeń");
                Console.WriteLine("\n\tB. Projekt Nr 1: Kalkulator obliczeń");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z) programu");
                // podpowiedź dla Użytkownika, co on ma zrobić
                Console.Write("\n\tDla wyboru wymaganej funkjonalności " +
                    "naciśnij odpowiedni klawisz (A lub B lub X): ");
                // wczytanie 'kodu' naciśniętego klawisza
                WybranaFunkcjonalność = Console.ReadKey();
                // rozpoznanie 'kodu' naciśniętego klawisza
                if (WybranaFunkcjonalność.Key == ConsoleKey.A)
                {
                    /* wywołanie metody dla obliczania wielkości matematycznych
                       "obsługiwanych" przez metody realizowane na zajęciach laboratoryjnych*/
                    KalkulatorObliczeńLaboratoryjnychNr1();
                }
                else if (WybranaFunkcjonalność.Key == ConsoleKey.B)
                {
                    /* wywołanie metody dla obliczania wielkości matematycznych
                       "obsługiwanych" przez samodzielnie zaprojektowane metody w ramach pracy własnej */
                    apKalkulatorObliczeńProjektuNr1();
                }
                else if (WybranaFunkcjonalność.Key != ConsoleKey.X)
                {
                    // sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: nacisnąłeś niedozwolony znak");

                    // chwilowe zatrzymanie programu
                    Console.WriteLine("\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
                    // program czeka na naciśnięcie dowlonego klawisza
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\n\tTo teraz nastąpi zakończenie działania programu");
                }
            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);

            //wypisanie informacji o Autorze programu
            Console.WriteLine("\n\tAutor programu: Antoni Piwowarski, Numer albumu: 62024");
            // wypisanie daty i godziny zakończenia działania programu
            Console.WriteLine("\n\tData i godzina zakończenia działania programu: {0}", DateTime.Now);
            // chwilowe zatrzymanie programu
            Console.WriteLine("\n\tDla zakończenia działania programu naciśnij dowolny klawisz");

            Console.ReadKey();
        }
        // deklaracje metod własnych
        #region Deklaracje metod obsługi funkcjonalności Kalkulatora Laboratoryjnego
        static void KalkulatorObliczeńLaboratoryjnychNr1()
        {
            // deklaracja zmiennej dla przechowania kodu (numeru) wybranej funkcjonalności
            ConsoleKeyInfo WybranaFunkcjonalnosc;
            // ustawienie kolorów dla Kalkulatora laboratoryjnego
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Red;

            do // powtarzanie możliwości wyboru funkcjonalności Kalkulatora
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                // wyczyszczenie okna konosli
                Console.Clear();
                // wypisanie metryki Kalkulatora
                Console.WriteLine("\n\n\t\tKalkulator Laboratoryjny");

                // wypisanie Menu Kalkulatora
                Console.WriteLine("\n\n\tMenu Kalkulatora");
                Console.WriteLine("\n\tA. Obliczenie sumy arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tC. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tD. Wyznaczanie pierwiastków równania kwadratowego");
                Console.WriteLine("\n\tE. Obliczanie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\n\tF. Konwerter liczb");
                Console.WriteLine("\n\tX. Zakończenie (wyjśćie z) Kalkulatora obliczeń z zajęć laboratoryjnych");

                Console.Write("\n\tNaciśnięciem odpowiedniego klawisza (A, B, C, D, E, F lub X) wybierz jedną z oferowanych funkcjonalności: ");
                // wczytanie 'kodu' naciśniętego klawisza
                WybranaFunkcjonalnosc = Console.ReadKey();

                // rozpoznanie wybranej funkcjonalności
                switch (WybranaFunkcjonalnosc.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\n\tWybrano: A. Obliczenie sumy arytmetycznej wyrazów ciągu liczbowego");
                        float Suma;
                        ushort n;
                        // obliczenie sumy wyrazów ciągu liczbowego
                        SumaWyrazowCiaguLiczbowego(out Suma, out n);
                        // wypisanie wyniku
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: suma arytmetyczna wyrazów ciągu liczbowego o liczności {0} jest równa S = {1, 8:F3}", n, Suma);
                        // inne formaty wypisywania liczb typu float
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: suma arytmetyczna wyrazów ciągu liczbowego o liczności {0} jest równa S = {1, 8:E3}", n, Suma);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: suma arytmetyczna wyrazów ciągu liczbowego o liczności {0} jest równa S = {1, 8:G3}", n, Suma);
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("\n\n\tWybrano: B. Obliczenie iloczynu wyrazów ciągu liczbowego");
                        float Iloczyn;
                        Iloczyn = IloczynWyrazowCiaguLiczbowego();
                        // wypisanie wyniku
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów ciągu liczbowego jest równy: {0, 8:F2}", Iloczyn);
                        // inne formaty wypisywania liczb typu float
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów ciągu liczbowego jest równy: {0, 8:E2}", Iloczyn);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów ciągu liczbowego jest równy: {0, 8:G}", Iloczyn);
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("\n\n\tWybrano: C. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                        float SredniaArytmetyczna = SredniaArytmetycznaWyrazowCiaguLiczbowego(out n);
                        // wypisanie wyniku
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: iloczyn wyrazów ciągu liczbowego o liczności {0} jest równa S = {1, 8:F2}", n, SredniaArytmetyczna);
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\n\n\tWybrano: D. Wyznaczanie pierwiastków równania kwadratowego");
                        PierwiastkiRownaniaKwadratowego();
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("\n\n\tWybrano: E. Obliczanie wartości wielomianu n-tego stopnia");
                        // Horner
                        /* Dane wejściowe:
                         * n - stopień wielomianu
                         * x - wartość zmiennej niezależnej: typu float
                         * ai - wartości współczynnika: typu float
                         */
                        // deklaracje zmiennych dla przechowania wyników obliczeń
                        //ushort n; jest zadeklarowana w obsłudze case ConsoleKey.A
                        float x; // wczytana wartość zmiennej niezależnej x
                        float Wx; // obliczona wartość wielomianu
                        // wywowałanie metody obliczającej wartość wielomianu metodą Hornera
                        ObliczenieWartosciWielomianu(out Wx, out x, out n);
                        // wypisanie wyników obliczeń
                        Console.WriteLine("\n\n\tWYNIKI: obliczona wartość wielomianu {0}-go stopnia dla zmiennej niezależnej x = {1, 6:F2} jest równa: {2, 8:F2}", n, x, Wx);
                        // to samo, ale w innym formacie typu float
                        // format wykładniczy
                        Console.WriteLine("\n\n\tWYNIKI: obliczona wartość wielomianu {0}-go stopnia dla zmiennej niezależnej x = {1, 6:E2} jest równa: {2, 8:E2}", n, x, Wx);

                        // format najlepszego dostosowania formatu do wypisywanej wartości
                        Console.WriteLine("\n\n\tWYNIKI: obliczona wartość wielomianu {0}-go stopnia dla zmiennej niezależnej x = {1, 6:G} jest równa: {2, 8:G}", n, x, Wx);
                        break;
                    case ConsoleKey.F:
                        KonwerterLiczb();
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("\n\n\tTrwa zamykanie kalkulatora");
                        break;
                    default: //chyba jest błąd?
                        Console.WriteLine("\n\n\tERROR: Nacisnąłeś niedozwolony znak");
                        break;
                }
                //chwilowe zatrzymanie programu
                //Console.WriteLine("\n\tDla kontynuowania działania programu naciśnij dowolny klawisz");

                if (WybranaFunkcjonalnosc.Key != ConsoleKey.F)
                {
                    Console.WriteLine("\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");

                    Console.ReadKey();
                }
            } while (WybranaFunkcjonalnosc.Key != ConsoleKey.X);
            //chwilowe zatrzymanie programu
            //Console.WriteLine("\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
            //program czeka na naciśnięcie dowlonego klawisza
            //Console.ReadKey();
        }
        static void SumaWyrazowCiaguLiczbowego(out float S, out ushort n)
        {
            // pomocniczo wypisujemy wartości testowe wyjściowym parametrom formalnym 
            S = 0.0f; n = 0; // warunek brzegowy
            // deklaracja zmiennej dla przechowania wartości wczytywanego wyrazu ciągu liczbowego
            float a;

            // wczytanie liczności ciągu liczbowego
            Console.Write("\n\n\tPodaj liczność ciągu liczbowego: ");

            // w programach konsolowych wczytujemy dane wejściowe (liczby) stosując metodę TryParse(...)
            while (!ushort.TryParse(Console.ReadLine(), out n))
            {
                // sygnalizacja błędu
                Console.WriteLine("\n\n\tERROR: w podanym zapisie liczności wyrazów ciągu liczbowego wystąpił niedozwolony znak");
                // wczytanie ponowne licznośći ciągu liczbowego
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego: ");
            }

            // ustalenie warunków brzegowych (początkowych)
            S = 0.0f;
            // iteracyjne powtarzanie sumowania wyrazów ciągu liczbowego
            for (ushort i = 1; i <= n; i++)
            {
                // wczytanie i-tej wartości wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", i);
                //a = float.Parse(Console.ReadLine());

                // w programach konsolowych wczytujemy dane wejściowe (liczby) stosując metodę TryParse(...)
                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    // sygnalizacja błędu 
                    Console.WriteLine("\n\n\tERROR: w zapisie {0}-ego wyrazu ciągu liczbowego wystąpił niedozwolony znak", i);
                    Console.Write("\n\tPodaj ponownie wartość {0}-ego wyrazu ciągu liczbowego: ", i);
                }
                // iteracyjne sumowanie
                S += a;
            }
        }
        static float IloczynWyrazowCiaguLiczbowego()
        {
            ushort n;
            float a;
            float Iloczyn;

            // wczytanie liczności ciągu liczbowego
            Console.Write("\n\n\tPodaj liczność ciągu liczbowego: ");

            // w programach konsolowych wczytujemy dane wejściowe (liczby) stosując metodę TryParse(...)
            while (!ushort.TryParse(Console.ReadLine(), out n))
            {
                // sygnalizacja błędu
                Console.WriteLine("\n\n\tERROR: w podanym zapisie liczności wyrazów ciągu liczbowego wystąpił niedozwolony znak");
                // wczytanie ponowne licznośći ciągu liczbowego
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego: ");

            }

            // ustalenie warunków brzegowych (początkowych)
            Iloczyn = 1.0f;
            // iteracyjne powtarzanie mnożenia wyrazów ciągu liczbowego
            for (ushort i = 1; i <= n; i++)
            {
                // wczytanie i-tej wartości wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", i);

                // w programach konsolowych wczytujemy dane wejściowe (liczby) stosując metodę TryParse(...)
                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    // sygnalizacja błędu 
                    Console.WriteLine("\n\n\tERROR: w zapisie {0}-ego wyrazu ciągu liczbowego wystąpił niedozwolony znak", i);
                    Console.Write("\n\tPodaj ponownie wartość {0}-ego wyrazu ciągu liczbowego: ", i);
                }
                // iteracyjne mnożenie
                Iloczyn *= a;
            }
            return Iloczyn;
        }
        static float SredniaArytmetycznaWyrazowCiaguLiczbowego(out ushort n)
        {
            // deklaracja pomocnicza
            float Suma;
            // obliczenie sumy arytmetycznej wyrazów ciągu liczbowego
            SumaWyrazowCiaguLiczbowego(out Suma, out n);
            // obliczenie średniej arytmetycznej i jej zwrotne przekazanie do miejsca wywoałania metody: SredniaArytmetycznaWyrazowCiaguLiczbowego
            return Suma / n;
        }
        static void PierwiastkiRownaniaKwadratowego()
        {
            // deklaracja zmiennych programu
            float a, b, c; // dla przechowania wczytanych danych wejściowych
            float Delta; // dla przechowania pośredniego wyniku obliczeń
            float X1, X2, X1i2; // dla przechowania wyników obliczeń

            // wczytanie danych wejściowych i sprawdzenie warunku wejściowego: a != 0.0
            do
            {
                // wczytanie wartości współczynnika a
                Console.Write("\n\tWprowadź wartość współczynnika a: ");
                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    // był błąd! to powiadamiamy o nim użytkownika programu
                    Console.WriteLine("\n\tERROR: w zapisie wartości współczynnika a wystąpił niedozwolony znak!!!");
                    Console.Write("\n\tWprowadz ponownie wartość współczynnika a: ");
                }

                if (a == 0.0f)
                {
                    Console.Beep(); // "obudzenie" Użytkownika
                    Console.WriteLine("\n\tERROR: wartość współczynnika a nie może być równa 0.0");
                }
            } while (a == 0.0f);

            // wczytanie wartości pozostałych współczynników równania
            Console.Write("\n\tWprowadź wartość współczynnika b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("\n\tWprowadź wartość współczynnika c: ");
            c = Convert.ToSingle(Console.ReadLine());
            // obliczenie delty (wyróżnika równania kwadratowego)
            Delta = b * b - 4f * a * c;
            Console.WriteLine("\n\tObliczona wartość Delty: " + Delta);
            // rozpoznanie wartości delty
            if (Delta > 0.0f)
            {
                // obliczenie dwóch pierwiastków
                X1 = (-b - (float)Math.Sqrt(Delta)) / (2.0f * a);
                X2 = (-b + (float)Math.Sqrt(Delta)) / (2.0f * a);
                // wypisanie wyniku obliczeń
                Console.WriteLine("\n\tWYNIKI: X1 = {0} \t X2 = {1}", X1, X2);
            }
            else if (Delta < 0.0f)
                Console.WriteLine("\n\tRównanie nie ma pierwiastków rzeczywistych!");
            else
            {
                X1i2 = -b / (2.0f * a);
                Console.WriteLine("\n\tWYNIKI: X1i2 = {0}", X1i2);
            }
        }
        static void ObliczenieWartosciWielomianu(out float Wx, out float x, out ushort n)
        {
            // dla potrzeb testowych przypisujemy domyślne wartości parametrom wyjściowym
            Wx = 0.0f; x = 0.0f; n = 0;
            // deklaracja zmiennej dla przechowania wartości wczytanego współczynnika wielomianu
            float a;
            // wczytanie stopnia wielomianu
            apWczytajLiczbeNaturalna("\n\tPodaj stopień wielomianu", out n);

            Console.Write("\n\tPodaj wartość zmiennej niezależnej x: ");
            while (!float.TryParse(Console.ReadLine(), out x))
            {
                // sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w zapisie wartości zmiennej niezależnej x wystąpił niedozwolony znak");
                // ponowne wypisanie zaproszenia
                Console.Write("\n\tPodaj ponownie wartość zmiennej niezależnej x: ");
            }
            // obliczenie wartości wielomianu według schematu Hornera
            Wx = 0.0f; // warunek brzegowy (początkowy)
            // iteracyjne obliczanie wartości wielomianu
            for (ushort i = 1; i <= n + 1; i++)
            {// wczytanie wartości kolejnego współcznnika welomianu: n (n-1) ...
                Console.Write("\n\tPodaj wartość {0}-ego współczynnika wielomianu: ", n - (i - 1));
                while (!float.TryParse(Console.ReadLine(), out a))
                {// sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie wartości {0}-ego współczynnika wystąpił niedozwolony znak", n - (i - 1));
                    // ponowne zaproszenie do podania wartości współczynnika
                    Console.Write("\n\tPodaj ponownie wartość {0}-ego współczynnika wielomianu: ", n - (i - 1));
                }
                // iteracyjne sumowanie wielomianu
                Wx = Wx * x + a;
            }
        }
        static void KonwerterLiczb()
        {
            // deklaracja zmiennej dla przechowania kodu wciśniętego klawisza
            ConsoleKeyInfo WybranaFunkcjonalnosc;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            do // powtarzanie możliwości wyboru funkcjonalności Kalkulatora
            {
                // wyczyszczenie okna konosli
                Console.Clear();

                // wypisanie Metryki i Menu
                Console.WriteLine("\n\n\tMenu Konwertera liczb:");
                Console.WriteLine("\n\tA. Konwersja znakowego zapisu liczby naturalnej (w dziesiętnym systemie liczbowym) \n\t   na znakową liczbę naturalną w systemie binarnym");
                Console.WriteLine("\n\tB. Konwersja znakowego zapisu liczby naturalnej (w szesnastkowym systemie liczbowym) \n\t   na znakową liczbę naturalną w systemie trzynastkowym");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z) Konwertera liczb");

                // podpowiedź dla użytkownika programu, co ma teraz zrobić
                Console.Write("\n\n\tNaciśnięciem odpowiedniego klaiwsza (A, B lub X) wybierz wymaganą funkcjonalność: ");

                // wczytanie 'kodu' naciśniętego klawisza
                WybranaFunkcjonalnosc = Console.ReadKey();

                // rozpoznanie wybranej funkcjonalności
                if (WybranaFunkcjonalnosc.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n\n\tWybrano: A. Konwersja znakowego zapisu liczby naturalnej (w dziesiętnym systemie liczbowym) \n\t\t    na znakową liczbę naturalną w systemie binarnym");

                    /* dekomponujemy zadanie dla funkcjonalności F
                        1) konwersja zankowego zapisu liczby w systemie dziesiętnym na wartość
                        2) konwersja wartośći liczby naturalnej na znakowy zapis liczby dwójkowej                              
                    */
                    // ad 1.
                    string ZZL; // ZZL - Znakowy Zapis Liczby
                                // deklaracja zmiennej dla przechowania wartości liczby po konwersji
                    ushort LiczbaPoKonwersji;
                    Console.Write("\n\n\tPodaj liczbę naturalną (w systemie dziesiętnym) do konwersji: ");
                    // wczytanie liczby do konwersji
                    ZZL = Console.ReadLine();
                    // usunięcie zbędnych "białych znaków" (spacja, znak tabulacji)
                    ZZL = ZZL.Trim();
                    // konwersja znakowego zpaisu liczby na wartość
                    LiczbaPoKonwersji = KonwersjaZnakowejLiczbyNaWartosc(ZZL);
                    // dla celów testowych wypisujemy liczbę po konwersji przy użyciu metody WriteLine()
                    Console.WriteLine("\n\n\tTRACE: Liczba po konwersji: " + ZZL.ToString());
                    // 2) konwersja wartośći liczby naturalnej na znakowy zapis liczby dwójkowej
                    ushort LiczbaDoKonwersji = LiczbaPoKonwersji;
                    // Konwersja wartości (liczby ushort) na znakowy zapis w systemie dwójowym
                    KonwersjaLiczbyNaturalnejNaBinarna(LiczbaDoKonwersji, out ZZL);
                    // wypisanie wyników konwersji
                    Console.WriteLine("\n\n\tWYNIK KONWERSJI: Wartość liczby po konwersji ze znakowego jej zapisu w dziesiętnym systemie liczbowym: {0}, \n\t\tktóra po konweresji na system dwójkowy (binarny) ma następujący zapis znakowy: {1}", LiczbaPoKonwersji, ZZL);
                }
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.B)
                {
                    string ZZL16, ZZL13;
                    // wywołanie metody (metod) dla konwersji liczby 16-tkowej na liczbę 13-tkową;\
                    KonwersjaLiczby16NaLiczbe13(out ZZL16, out ZZL13);
                    // wypisanie wyniku konwersji
                    Console.WriteLine("\n\n\tWYNIKI KONWERSJI: liczba 16-tkowa {0} na znakowy zapis liczby 13-tkowej wynosi: {1}", ZZL16, ZZL13);
                }
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.X)
                {
                    Console.WriteLine("\n\n\tTrwa zamykanie programu");
                }
                else if (WybranaFunkcjonalnosc.Key != ConsoleKey.X)
                {
                    Console.WriteLine("\n\n\tERROR: Nacisnąłeś niedozwolony znak");
                }
                // chwilowe zatrzymanie programu
                Console.WriteLine("\n\tDla kontynuowania działania programu naciśnij dowolny klawisz");

                Console.ReadKey();
            } while (WybranaFunkcjonalnosc.Key != ConsoleKey.X);

            ////chwilowe zatrzymanie programu
            //Console.WriteLine("\n\n\tDla kontynuacji działania programu naciśnij dowolny klawisz");
            ////program czeka na naciśnięcie dowlonego klawisza
            //Console.ReadKey();
        }
        static ushort KonwersjaZnakowejLiczbyNaWartosc(string ZZL)
        {
            // deklaracje 
            ushort L;
            int N; // cyfra cyfr w ZZL
            byte p = 10; // podsatwy systemu liczbowego dla ZZL
            char Cyfra;
            // określenie (odczytanie cyfr w ZZL
            N = ZZL.Length;
            // konwersja ZZL na wartość według schematu Hornera
            L = 0; // warunek brzegowy
            for (byte i = 0; i < N; i++)
            {
                // pobranie z ZZL i-tej cyfry
                Cyfra = ZZL[i];
                // sprawdzenie, czy to jest na pewno cyfra: 0 1 ... 9;
                if ((Cyfra >= '0') && (Cyfra <= '9'))
                    L = (ushort)(L * p + ((byte)Cyfra - (byte)'0'));
                else
                {
                    // sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie liczby do konwersji wystąpił niedozwolony znak");
                    // chwilowe zatrzymanie programu
                    Console.WriteLine("\n\tDla  zakończenie działania programu wciśnij dowolny klawisz");

                    Console.ReadKey();

                    return 0;
                }
            }// od for
            // zwrotne przekazanie wyniku konwersji
            return L;
        }
        static void KonwersjaLiczbyNaturalnejNaBinarna(ushort L, out string ZZL)
        {
            // konwersja liczby (wartości) L na zapis znakowy w dwójkowym systemie liczbowym
            string SchowekReszt = ""; // deklaracja i wyzerowanie "schowka" dla reszt z dzielenia
            byte Reszta; // dla przechowania reszty z dzielenia
            int Licznik = 0; // dla liczenia reszt z dzielenia wpisywanych do zmiennej SchowekReszt
            byte q = 2; // podsatwa systemu liczbowego dla liczby wyjściowej (po konwersji)

            // wyznaczanie znakowego zapisu liczby w dziesiętnym systemie liczbowym
            while (L > 0) // powtarzamy obliczenia podczas gdy (L > 0)
            {
                Reszta = (byte)(L % q); // dzielenie modulo
                // dodanie do tworzonego łańcucha znaków reszt z dzielenia nowej Reszty
                SchowekReszt = SchowekReszt + (char)(Reszta + (byte)'0');
                // zwiększenie licznika znaków (reszt z dzielenia) wpisanych do zmiennej SchowekReszt
                Licznik++;
                // obliczenie wyniku dzielenia całkowitoliczbowego przez podstawę systemu liczbowego
                L = (ushort)(L / q);
            }
            // odwrócenie znakowgo zapisu reszt z dzielenia wpisanych do zmiennej SchowekReszt
            ZZL = ""; // wyzerowanie zmiennej typu 'string'
            for (int j = Licznik - 1; j >= 0; j--)
                ZZL = ZZL + SchowekReszt[j];
            // wynik będzie przekazany przez parametr wyjściowy: ZZL
        }
        static void KonwersjaLiczby16NaLiczbe13(out string ZZL16, out string ZZL13)
        {
            // pomocnicze przypisanie wartość parametrom wyjściowym
            ZZL16 = ZZL13 = "";
            // deklaracje pomocnicze
            byte p = 16;
            byte q = 13;
            int L;
            char Cyfra;
            int N;
            // wypisanie zaproszenia do podania znakowego zapisu liczby szesnastkowej
            Console.Write("\n\n\tPodaj znakowy zapis liczby szesnastkowej: ");
            ZZL16 = Console.ReadLine();
            // usunięcie tzw. białych znaków 
            ZZL16 = ZZL16.Trim();
            // określenie (odczytanie) liczby cyfr podanej liczby
            N = ZZL16.Length;
            // interacyjna konwersja znakowego zapisu liczby na wartość według schematu Hornera
            L = 0;
            for (int i = 0; i < N; i++)
            {
                // pobranie i-tej cyfry
                Cyfra = ZZL16[i];
                // rozpoznanie pobranej cyfry
                if (Cyfra >= '0' && Cyfra <= '9')
                    // iteracyjne wyznaczanie waetości liczby według schematu Hornera 
                    L = L * p + ((byte)Cyfra - (byte)'0');
                else
                {
                    // pomocnicze przejście na wielkie litery
                    Cyfra = char.ToUpper(Cyfra);
                    if (Cyfra >= 'A' && Cyfra <= 'F')
                        // iteracyjne wyznaczanie waetości liczby według schematu Hornera 
                        L = L * p + (((byte)Cyfra - (byte)'A') + 10);
                    else
                    {
                        // sygnalizujemy błąd 
                        Console.WriteLine("\n\n\tERROR: w zapisie liczby szesnastkowej wystąpił niedozwolony znak");
                        Console.WriteLine("\n\tDla kontynuacji obliczeń naciśnij dowolny klawisz");
                        Console.ReadKey();
                        // przerwanie dalszej kontynuacji
                        return; // ale niekoniecznie
                    }
                }
            }// od for
            Console.WriteLine("\n\n\tTrace: wartość liczby do konwersji = {0} w zapisie szestnastkowym ma postać: {1, 6:X}", L, L);
            // konwersja wartości L na znakowy zapis liczby w systemie 13-tkowym
            // deklaracja dla potrzeb konwersji
            byte Reszta; // dla przechowania reszty z dzielenia: % 13
            string SchowekReszt = ""; // dla przechowania reszt z dzielenia
            byte Licznik = 0; // licznik reszt
            while (L > 0) // w L jest wartość liczby po konwersji z zapisu znakowego w 16-tkowym systemie liczbowym
            {
                // obliczenie kolejnej reszty
                Reszta = (byte)(L % q);
                // dodanie reszty jako kodu odpowiedniej cyfry do SchowkaReszt
                if (Reszta < 10)
                    SchowekReszt = SchowekReszt + (char)(Reszta + (byte)'0');
                else
                    SchowekReszt = SchowekReszt + (char)((Reszta - 10) + (byte)'A');
                // zwiększenie licznika reszt w SchowkuReszt 
                Licznik++;
                // obliczenie kolejnego wyniku dzielenia całkowitego
                L = L / q;
            }
            // odwrócenie zapisu w SchowekReszt
            ZZL13 = ""; // warunek brzegowy
            // odwrócenie zapisu reszt 
            for (int i = Licznik - 1; i >= 0; i--)
            {
                ZZL13 = ZZL13 + SchowekReszt[i];
            }
        }
        #endregion

        #region Deklaracje metod obsługi funkcjonalności Kalkulatora indywidualnego
        static void apKalkulatorObliczeńProjektuNr1()
        {
            ConsoleKeyInfo WybranaFunkcjonalnosc;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            do
            {
                // wyczyszczenie konsoli
                Console.Clear();
                Console.WriteLine("\n\n\tMENU funkcjonalne Kalkulatora:");
                // przedstawienie dostępnych funkcjonalności kalkulatora
                Console.WriteLine("\n\tA. Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tB. Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tC. Obliczenie średniej potęgowej (średniej uogólnionej) wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tD. Obliczenie średniej geometrycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tE. Obliczenie ceny jednostki paszy (według średniej ważonej) \n\t   składającej się (utworzonej, skompowanej) z kilku składników");
                Console.WriteLine("\n\tF. Obliczenie wartości wielomianu n-tego stopnia według schematu Hornera");
                Console.WriteLine("\n\tG. Konwersja liczby całkowitej zapisanej znakowo w systemie liczbowym \n\t   o podanej podstawie liczenia na wartość i jej wypisanie znakowo \n\t   w innym systemie liczbowym o podanej postawie liczenia");
                Console.WriteLine("\n\tH. Konwersja liczby stałopozycyjnej (bez znaku), zapisanej w systemie dziesiętnym, na liczbę \n\t   stałopozycyjną zapisaną w systemie binarnym");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z) 'Kalkulator obliczeń zadania projektowego Nr 1'");
                Console.Write("\n\tNaciśnięciem odpowiedniego klawisza (A, B, C, D, E, F, G, H lub X) wybierz jedną z funckjonalności: ");

                // wczytanie klawisza z klawiatury
                WybranaFunkcjonalnosc = Console.ReadKey();

                // w zależności od kliniętego klawisza, włącza się inna funkcja
                switch (WybranaFunkcjonalnosc.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\n\tWybrano: A. Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                        double apsrednia;
                        ushort apdlugosc;
                        apObliczenieSredniejHarmonicznej(out apsrednia, out apdlugosc);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: średnia harmoniczna ciągu liczbowego o liczności {0} jest równa {1, 2:F2}", apdlugosc, apsrednia);
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("\n\n\tWybrano: B. Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
                        apObliczenieSredniejKwadratowej(out apsrednia, out apdlugosc);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: średnia kwadratowa ciągu liczbowego o liczności {0} jest równa {1, 2:F2}", apdlugosc, apsrednia);
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("\n\n\tWybrano: C. Obliczenie średniej potęgowej (średniej uogólnionej) wyrazów ciągu liczbowego");
                        int aprzad;
                        apObliczenieSredniejPotegowej(out apsrednia, out apdlugosc, out aprzad);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: średnia potęgowa (średnia uogólniona) ciągu liczbowego o liczności {0} i rzędu {1} jest równa {2, 2:F2}", apdlugosc, aprzad, apsrednia);
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\n\n\tWybrano: D. Obliczenie średniej geometrycznej wyrazów ciągu liczbowego");
                        apObliczenieSredniejGeometrycznej(out apsrednia, out apdlugosc);
                        Console.WriteLine("\n\n\tWYNIKI OBLICZEŃ: średnia geometrczna ciągu liczbowego o liczności {0} jest równa {1, 2:F2}", apdlugosc, apsrednia);
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("\n\n\tWybrano: E. Obliczenie ceny jednostki paszy (według średniej ważonej) \n\t\t    składającej się (utworzonej, skompowanej) z kilku składników");
                        double appasza;
                        apObliczenieCenyJednostki(out appasza);
                        Console.WriteLine("\n\n\tObliczona cena 1 kg jednostki paszy jest równa: {0, 2:F2} (w zł)", appasza);
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("\n\n\tWybrano: F. Obliczenie wartości wielomianu n-tego stopnia według schematu Hornera");
                        ushort apstopien;
                        double apwartosc, apniezalezna;
                        apObliczenieWartosciWielomianu(out apstopien, out apniezalezna, out apwartosc);
                        Console.WriteLine("\n\n\tWYNIKI: obliczona wartość wielomianu {0}-go stopnia dla zmiennej niezależnej x = {1} jest równa: {2}", apstopien, apniezalezna, apwartosc);
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("\n\n\tWybrano: G. Konwersja liczby całkowitej zapisanej znakowo w systemie liczbowym \n\t\t    o podanej podstawie liczenia na wartość i jej wypisanie znakowo \n\t\t    w innym systemie liczbowym o podanej postawie liczenia");
                        apKonwersjaLiczb();
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("\n\n\tWybrano: H. Konwersja liczby stałopozycyjnej (bez znaku), zapisanej w systemie dziesiętnym, na liczbę \n\t\t    stałopozycyjną zapisaną w systemie binarnym");
                        apKonwersjaStaloPrzecinkowa();
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("\n\n\tTrwa zamykanie kalkulatora");
                        break;
                    default:
                        Console.WriteLine("\n\n\tERROR: nacisnąłeś niedozwolony klawisz (znak) - nie ma takiej funckjonalności w MENU funkcjonalnego Kalkulatora");
                        break;
                }

                Console.WriteLine("\n\tDla kontynuowania działania programu naciśnij dowolny klawisz");
                Console.ReadKey();
            } while (WybranaFunkcjonalnosc.Key != ConsoleKey.X);
        }
        static void apObliczenieSredniejHarmonicznej(out double apsrednia, out ushort apdlugosc)
        {
            // zainicjowanie potrzebynch zmiennych
            double apsuma = 0, apelement;

            // wczytanie liczności ciągu liczbowego
            apWczytajLiczbeNaturalna("\n\tPodaj liczność ciągu liczbowego", out apdlugosc);

            // wczytanie elementów ciągu liczbowego
            for (int i = 0; i < apdlugosc; i++)
            {
                apWczytajElementCiagu("Podaj wartość " + (i + 1) + "-ego wyrazu ciągu liczbowego", out apelement);
                // robienie odpowiedniej sumy, potrzebnej aby obliczyć średnią harmoniczną 
                apsuma += (1 / apelement);
            }
            // powstanie średniej harmonicznej
            apsrednia = apdlugosc / apsuma;
        }
        static void apObliczenieSredniejKwadratowej(out double apsrednia, out ushort apdlugosc)
        {
            // zainicjowanie potrzebynch zmiennych
            double apsuma = 0, apelement;

            // wczytanie liczności ciągu liczbowego
            apWczytajLiczbeNaturalna("\n\tPodaj liczność ciągu liczbowego", out apdlugosc);

            // wczytanie elementów ciągu liczbowego
            for (int i = 0; i < apdlugosc; i++)
            {
                apWczytajElementCiagu("Podaj wartość " + (i + 1) + "-ego wyrazu ciągu liczbowego", out apelement);
                // robienie odpowiedniej sumy, potrzebnej aby obliczyć średnią kwadratową 
                apsuma += apelement * apelement;
            }
            // powstanie średniej kwadratowej
            apsrednia = Math.Sqrt(apsuma / apdlugosc);
        }
        static void apObliczenieSredniejPotegowej(out double apsrednia, out ushort apdlugosc, out int aprzad)
        {
            // zainicjowanie potrzebynch zmiennych
            double apsuma = 0, apelement;

            // wczytanie liczności ciągu liczbowego
            apWczytajLiczbeNaturalna("\n\tPodaj liczność ciągu liczbowego", out apdlugosc);

            Console.Write("\n\tPodaj rząd ciagu liczbowego: ");
            // wczytanie rzędu średniej potęgowej
            while (!int.TryParse(Console.ReadLine(), out aprzad))
            {
                // sygnalizacja błędu
                Console.WriteLine("\n\n\tERROR: w podanym zapisie rzędu ciągu liczbowego wystąpił niedozwolony znak");
                // zachęcenie do ponownego podania rzędu średniej potęgowej
                Console.Write("\n\tPodaj ponownie rząd ciągu liczbowego: ");
            }
            // wczytanie elementów ciągu liczbowego
            for (int i = 0; i < apdlugosc; i++)
            {
                Console.Write("\n\tPodaj {0} wyraz ciagu: ", i + 1);
                while (!double.TryParse(Console.ReadLine(), out apelement) || apelement < 0)
                {
                    // sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie {0}-ego wyrazu ciągu liczbowego wystąpił niedozwolony znak ", i + 1);
                    // zachęcenie do ponownego podania wartości
                    Console.Write("\n\tPodaj ponownie wartość {0}-ego wyrazu ciągu liczbowego: ", i + 1);
                }
                // robienie odpowiedniej sumy, potrzebnej aby obliczyć średnią potęgową 
                apsuma += Math.Pow(apelement, aprzad);
            }
            // powstanie średniej potęgowej
            apsrednia = Math.Pow(apsuma / apdlugosc, 1.0 / aprzad);
        }
        static void apObliczenieSredniejGeometrycznej(out double apsrednia, out ushort apdlugosc)
        {
            // zainicjowanie potrzebynch zmiennych
            double apiloczyn = 1, apelement;

            // wczytanie liczności ciągu liczbowego
            apWczytajLiczbeNaturalna("\n\tPodaj liczność ciągu liczbowego", out apdlugosc);
            // wczytanie elementów ciągu liczbowego
            for (int i = 0; i < apdlugosc; i++)
            {
                apWczytajElementCiagu("Podaj wartość " + (i + 1) + "-ego wyrazu ciągu liczbowego", out apelement);
                // robienie iloczynu elementów, potrzebnego aby obliczyć średnią geometryczną 
                apiloczyn *= apelement;
            }
            // powstanie średniej geometrycznej
            apsrednia = Math.Pow(apiloczyn, 1.0 / apdlugosc);
        }
        static void apObliczenieCenyJednostki(out double appasza)
        {
            // zainicjowanie potrzebnych danych
            double apcena, apmasa, apsuma = 0, apsumam = 0;
            ushort apliczba;

            Console.Write("\n\n\tPodaj liczbę składników: ");
            // wczytanie liczby szkładników
            while (!ushort.TryParse(Console.ReadLine(), out apliczba) || apliczba < 0)
            {
                if (apliczba < 0)
                    //sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: liczba składników nie może być mniejsza od 0");
                else
                    //sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie liczby składników wystąpił niedozwolony znak");
                // zachęcenie do ponownego podania liczby składników
                Console.Write("\n\tPodaj ponownie liczbę składników: ");
            }
            // wczytanie cen oraz mas składników
            for (int i = 0; i < apliczba; i++)
            {
                Console.Write("\n\tPodaj masę {0} składnika (w kg): ", i + 1);

                while (!double.TryParse(Console.ReadLine(), out apmasa) || apmasa < 0)
                {
                    if (apmasa < 0)
                        // sygnalizacja błędu
                        Console.WriteLine("\n\n\tERROR: masa nie może być mniejsza od 0");
                    else
                        // sygnalizacja błędu
                        Console.WriteLine("\n\n\tERROR: w podanym zapisie masy wystąpił niedozwolony znak");
                    // zachęcenie do ponownego podania masy składnika
                    Console.Write("\n\tPodaj ponownie mase {0} składnika (w kg): ", i + 1);
                }
                Console.Write("\tOraz jego cenę za 1kg (w zł): ");

                while (!double.TryParse(Console.ReadLine(), out apcena) || apcena < 0)
                {
                    if (apmasa < 0)
                        // sygnalizacja błędu
                        Console.WriteLine("\n\n\tERROR: cena nie może być mniejsza od 0");
                    else
                        // sygnalizacja błędu
                        Console.WriteLine("\n\n\tERROR: w podanym zapisie ceny wystąpił niedozwolony znak");
                    // zachęcenie do ponownego podania ceny składnika
                    Console.Write("\n\tPodaj ponownie jego cenę za 1kg (w zł): ");
                }
                // suma iloczynu ceny i masy, potrzebnej, aby policzyć cenę jednostki paszy
                apsuma += apcena * apmasa;
                // suma masy, potrzebnej, aby policzyć cenę jednostki paszy
                apsumam += apmasa;
            };

            // zabezpieczenie się na wypadek 0 składników i zerowej masy składników
            if (apliczba == 0 || apsumam == 0)
                appasza = 0;
            // cena jednostki paszy
            else
                appasza = apsuma / apsumam;
        }
        static void apObliczenieWartosciWielomianu(out ushort apstopien, out double apniezalezna, out double apwartosc)
        {
            double apwspolczynnik;
            apwartosc = 0;

            apWczytajLiczbeNaturalna("\n\tPodaj stopień wielomianu", out apstopien);
            // wczytanie wartośći zmiennej niezależnej, jeśli spełni wymagania
            Console.Write("\n\tPodaj wartość zmiennej niezależnej x: ");
            while (!double.TryParse(Console.ReadLine(), out apniezalezna))
            {
                // sygnalizacja błędu
                Console.WriteLine("\n\n\tERROR: w podanym zapisie wartości zmiennej niezależnej wystąpił niedozwolony znak");
                // zachęcenie do ponownego podania zmiennej niezależnej
                Console.Write("\n\tPodaj ponownie wartość zmiennej niezależnej: ");
            }

            // wczytanie każdego współczynnika wielomianu
            for (int i = 0; i < apstopien + 1; i++)
            {
                // zaproszenie do podania współczynnika wielomianu
                Console.Write("\n\tPodaj wspolczynnik wielomianu przy {0}-tej potędze: ", apstopien - i);
                while (!double.TryParse(Console.ReadLine(), out apwspolczynnik))
                {
                    // sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie wspolczynnika wielomianu wystąpił niedozwolony znak");
                    // zaproszenie do ponownego podania współczynnika wielomianu
                    Console.Write("\n\tPodaj wspolczynnik wielomianu przy {0}-tej potędze: ", apstopien - i);
                }
                // obliczenie wartości wielomianu
                apwartosc = apwartosc * apniezalezna + apwspolczynnik;
            }
        }
        static void apKonwersjaLiczb()
        {
            // deklaracja zmiennych
            string apliczbain = "", apliczbaout = "";

            ushort app, apq;
            int apL;
            char apCyfra;
            int apN;
            Console.Write("\n\n\tPodaj liczbę, którą chciałbyś przekonwertować: ");
            // wczytanie liczby
            apliczbain = Console.ReadLine();
            apliczbain = apliczbain.Trim();
            int ile = 0;
            bool apczyminus = false;

            // sprawdzenie czy jest to liczba ujemna, jeżeli jest, to program usuwa -
            if (apliczbain[0] == '-')
            {
                apczyminus = true;
                apliczbain = apliczbain.Remove(0, 1);
            }

            // policzenie akceptowalnych znaków w liczbie
            for (int i = 0; i < apliczbain.Length; i++)
            {
                apCyfra = apliczbain[i];
                apCyfra = char.ToUpper(apCyfra);
                if ((apCyfra >= '0' && apCyfra <= '9') || (apCyfra >= 'A' && apCyfra <= 'Z'))
                    ile++;
                else
                {
                    ile--;
                }
            }

            // jeżeli wystąpiły jakieś nieakceptowalne liczby, to program prosi użytkownika o ponowne podanie liczby
            while (ile != apliczbain.Length)
            {
                ile = 0;
                Console.WriteLine("\n\n\tERROR: w podanym zapisie liczby wystąpił niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczbę, którą chciałbyś przekonwertować:: ");
                apliczbain = Console.ReadLine();
                if (apliczbain[0] == '-')
                    apliczbain = apliczbain.Trim();
                {
                    apczyminus = true;
                    apliczbain = apliczbain.Remove(0, 1);
                }
                for (int i = 0; i < apliczbain.Length; i++)
                {
                    apCyfra = apliczbain[i];
                    apCyfra = char.ToUpper(apCyfra);
                    if ((apCyfra >= '0' && apCyfra <= '9') || (apCyfra >= 'A' && apCyfra <= 'Z'))
                        ile++;
                    else
                        ile--;
                }
            }
            apN = apliczbain.Length;

            apliczbain = apliczbain.ToUpper();
            string appomoc = apliczbain;
            appomoc = apSort(apliczbain);
            string apznaki = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int apileznaki = 1;

            // sprawdzenie, jaki jest system liczbowy podanej przez użytkownika liczby
            for (int i = 0; i < apznaki.Length; i++)
            {
                if (appomoc[appomoc.Length - 1] == apznaki[i])
                    break;
                else
                    apileznaki++;
            }

            Console.Write("\n\tPodaj system liczbowy, w którym jest liczba: ");
            // wczytanie systemu liczbowego, w którym jest liczba podana przez użytkownika, jeśli spełnia wymagania
            while (!ushort.TryParse(Console.ReadLine(), out app) || app < 2 || app > 36 || app < apileznaki)
            {
                // sygnalizacja błędu
                if (app < apileznaki && app >= 2)
                    Console.WriteLine("\n\n\tERROR: podany system liczbowy nie jest systemem liczbowym podanej liczby");
                else
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie systemu liczbowego wystąpił niedozwolony znak");
                // zachęcenie do ponownego podania systemu liczbowego
                Console.Write("\n\tPodaj ponownie system liczbowy, w którym jest liczba: ");
                apileznaki = 1;
                for (int i = 0; i < apznaki.Length; i++)
                {
                    if (appomoc[appomoc.Length - 1] == apznaki[i])
                        break;
                    else
                        apileznaki++;
                }
            }

            Console.Write("\n\tPodaj na jaki system liczbowy chcesz tę liczbę zamienić: ");
            // wczytanie systemu liczbowego, na który użytkownik chce przekonwertować swoją liczbę, jeśli spełnia wymagania
            while (!ushort.TryParse(Console.ReadLine(), out apq) || apq < 2 || apq > 36)
            {
                // sygnalizacja błędu
                Console.WriteLine("\n\n\tERROR: w podanym zapisie systemu liczbowego wystąpił niedozwolony znak");
                // zachęcenie do ponownego podania systemu liczbowego
                Console.Write("\n\tPodaj ponownie na jaki system liczbowy chcesz tę liczbę zamienić: ");
            }

            apL = 0;
            // konwersja znakowego zapisu liczby na wartość
            for (int i = 0; i < apN; i++)
            {
                apCyfra = apliczbain[i];
                apCyfra = char.ToUpper(apCyfra);
                if (apCyfra >= '0' && apCyfra <= '9')
                    apL = apL * app + ((int)apCyfra - (int)'0');
                else if (apCyfra >= 'A' && apCyfra <= 'F')
                {
                    apL = apL * app + (((int)apCyfra - (int)'A') + 10);
                }
                else if (apCyfra >= 'G' && apCyfra <= 'P')
                {
                    apL = apL * app + (((int)apCyfra - (int)'G') + 16);
                }
                else
                    apL = apL * app + (((int)apCyfra - (int)'Q') + 26);
            }
            int apReszta;
            string apSchowekReszt = "";
            int apLicznik = 0;
            // konwersja na podany przez użytkownika system liczbowy
            while (apL > 0)
            {
                // zebranie wszystkich reszt
                apReszta = (int)(apL % apq);
                if (apReszta < 10)
                    apSchowekReszt = apSchowekReszt + (char)(apReszta + (int)'0');
                else if (apReszta >= 10 && apReszta <= 15)
                    apSchowekReszt = apSchowekReszt + (char)((apReszta - 10) + (int)'A');
                else if (apReszta >= 16 && apReszta <= 26)
                    apSchowekReszt = apSchowekReszt + (char)((apReszta - 16) + (int)'G');
                else
                    apSchowekReszt = apSchowekReszt + (char)((apReszta - 26) + (int)'Q');
                apLicznik++;
                apL = apL / apq;
            }
            // odwrotne połączenie ze sobą reszt
            apliczbaout = "";
            for (int i = apLicznik - 1; i >= 0; i--)
            {
                apliczbaout = apliczbaout + apSchowekReszt[i];
            }

            // wywowałnie wyniku
            if (apliczbain == "0")
                Console.WriteLine("\n\n\tLiczba po przekonwertowaniu: 0");
            else if (apczyminus == true)
                Console.WriteLine("\n\n\tLiczba po przekonwertowaniu: -" + apliczbaout);
            else
                Console.WriteLine("\n\n\tLiczba po przekonwertowaniu: " + apliczbaout);
        }
        static void apKonwersjaStaloPrzecinkowa()
        {
            // deklaracje podstaw systemów liczbowych
            const byte app = 10;
            const byte apq = 2;

            // dodatkowe deklaracje lokalne
            ushort apLc; // Lc - część całkowiat liczby do konwersji na wartość
            float apLu; // Lu = część ułamkowa liczby do konwersji na wartość

            string apLiczbaStalopozycyjna; // zmienna przechowująca liczbę podaną przez użytkownika
            // wczytanie liczby stałopozycyjnej do konwersji
            Console.Write("\n\n\tPodaj liczbę stałopozycyjną (z przecinkiem) do konwersji: ");
            apLiczbaStalopozycyjna = Console.ReadLine();

            // string przechowujący znaki akceptowalne przy podawaniu liczby przez użytkownika
            string apcyfry = ",0123456789";
            int apile = 0;

            // sprawdzenie czy użytkownik nie podał niedozwolonych znaków
            for (int i = 0; i < apLiczbaStalopozycyjna.Length; i++)
            {
                for (int j = 0; j < apcyfry.Length; j++)
                {
                    if (apLiczbaStalopozycyjna[i] == apcyfry[j])
                        apile++;
                }
            }
            // w przypadku podania nieodpowiednich znaków użytkownik jest ponownie zaproszony do podania liczby
            while (apile != apLiczbaStalopozycyjna.Length || apLiczbaStalopozycyjna[0] == ',' || apLiczbaStalopozycyjna[apLiczbaStalopozycyjna.Length - 1] == ',')
            {
                apile = 0;
                Console.WriteLine("\n\n\tERROR: w zapisie liczby stałopozycyjnej wystąpił niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczbę stałopozycyjną (z przecinkiem) do konwersji: ");
                apLiczbaStalopozycyjna = Console.ReadLine();
                for (int i = 0; i < apLiczbaStalopozycyjna.Length; i++)
                {
                    for (int j = 0; j < apcyfry.Length; j++)
                    {
                        if (apLiczbaStalopozycyjna[i] == apcyfry[j])
                            apile++;
                    }
                }
            }

            string[] apDwieCzesciLiczbyStalopozycyjnej; // tablica dla przechowania zankowego zapisu części całkowitej i ułamkowej liczby stałopozycyjnej do konwersji na wartość
            apDwieCzesciLiczbyStalopozycyjnej = apLiczbaStalopozycyjna.Split(new char[] { ',' }); // rozdzielenie podanej liczby przez użytkownika między przecinkiem

            string apZZL = apDwieCzesciLiczbyStalopozycyjnej[0]; // pobranie części całkowitej
            apZZL = apZZL.TrimStart(); // usunięcie spacji przez zapisem liczby stałopozycyjnej
            int apN = apZZL.Length; // określenie liczby cyfr w zankowym zapisie części całkowitej lcizby do konwersji

            char apCyfra;
            // konwersja cyfrowego zapisy liczby na wartość według schematu Hornera
            apLc = 0; // poczatkowy stań obliczeń (warunek brzegowy) schematu iteracyjnego

            for (int i = 0; i < apN; i++)
            {
                apCyfra = apZZL[i]; // pobranie i-tej cyfry części całkowitej liczby do konwersji
                apLc = (ushort)(apLc * app + ((byte)apCyfra - (byte)'0'));
            }
            float apLiczbaFloat; // dla liczby stałopozycjnej po konwersji na wartość
            // sprawdzenie, czy wczytana liczba miała część ułamkową, gdyż tylko wtedy tablica DwieCzęściLiczbyStałopozycyjnej będzie miała 2 pozycje: w pierwszej będzie znakowy zapis części całkowitej liczby, a w drugiej będzie znakowy zapis jej części ułamkowej
            if (apDwieCzesciLiczbyStalopozycyjnej.Length == 2) // true, gdy była część ułamkowa liczby
            {
                // pobranie części ułamkowej liczby stałopozycyjnej do konwersji
                apZZL = apDwieCzesciLiczbyStalopozycyjnej[1];
                apZZL = apZZL.TrimEnd();  // usunięcie spacji po części ułamkowej liczbie
                apN = apZZL.Length; // określenie liczby cyfr w znakowym zapisie liczby do konwersji
                // iteracyjne wyznaczenie wartości części ułamkowej liczby według schematu Hornera
                apLu = 0.0f; // początkowy stan obliczeń (warunek brzegowy) schematu iteracyjnego
                float apJednaDziesiata = 1.0f / app;  // pomocniczo, dla minimalizacji działań w instrukcji 'for'
                for (int i = apN - 1; i >= 0; i--)
                {// pobieramy cyfry od "końca"
                    apCyfra = apZZL[i]; // pobranie i-tej cyfry liczby do konwersji
                    apLu = (float)(apLu * apJednaDziesiata + ((byte)apCyfra - (byte)'0'));
                }
                // końcowe wyznaczenie części ułamkowej Lu liczby do konwersji
                apLu = apLu * apJednaDziesiata;

                // złożenie części całkowitej Lc z częścią ułamkową Lu liczby do konwersji
                apLiczbaFloat = (float)apLc + apLu;
            }
            else
            { // gdy była to liczba tylko całkowita, to przyjmujemy, że część ułamkowa jest róna zero
                apLu = 0.0f;
                apLiczbaFloat = (float)apLc + apLu;
            }
            // deklaracja liczby przed przecinkiem i po przecinku 
            string aplewo, apprawo;

            // konwersja liczby przed przecinkiem na liczbę binarną
            KonwersjaLiczbyNaturalnejNaBinarna(apLc, out aplewo);
            // przypisanie zmiennej wartości po przecinku liczby podanej przez użytkownika 
            apprawo = apDwieCzesciLiczbyStalopozycyjnej[1];
            float apprawo2;
            // dlugosc liczby po przecinku
            int apdl = apprawo.Length;
            // konwersja string na float
            apprawo2 = float.Parse(apprawo);
            // ilość liczb po przecinku w systemie binarnym jest o jeden większa od tego ile ich jest po przecinku w systemie dziesiętnym
            char[] apreszta = new char[apdl + 1];
            // deklarcaja licznika
            int aplicznik = 0;
            int apliczba = 1;
            //wyznaczanie dlugosci liczby, na którą trzeba ją podzielić
            while (apliczba < apprawo2)
                apliczba *= 10;
            int apilezer = 0;
            bool apczy = false;
            // liczenie zer przed liczbą po przecinku, np. 12,0062 -> ilezer = 2
            for (int i = 0; i < apdl - 1; i++)
            {
                if (apprawo[i] == '0')
                    apilezer++;
                else
                    break;
            }
            // dzielenie liczby po przecinku adekwatnie do liczby zer przed liczbą 
            for (int i = 0; i < apilezer; i++)
                apprawo2 /= 10;
            // mechanizm konwersji liczby stałoprzecinkowej z systemu dziesiętnego na dwójkowy 
            while (aplicznik != apdl + 1)
            {
                // jeżeli wyjdzie np. 1,232 -> usuwanie liczby przed przecinkiem, by zostało 0,232
                if (apprawo2 * apq / apliczba > 1)
                {
                    apreszta[aplicznik] = '1';
                    apprawo = (apprawo2 * apq / apliczba).ToString();
                    apprawo = apprawo.Remove(0, 2);
                    apprawo2 = float.Parse(apprawo);
                    while (apprawo2 < apliczba)
                    {
                        apprawo2 *= 10;
                        apczy = true;
                    }
                    if (apczy == true)
                        apprawo2 /= 10;
                    apczy = false;

                }
                // jeżeli wyjdzie np. 0,232 -> mnożenie 0,232 razy q (czyli 2)
                else if (apprawo2 * apq / apliczba < 1)
                {
                    apprawo2 *= apq;
                    apreszta[aplicznik] = '0';
                }
                // jeżeli wyjdzie idealnie, czyli np. 1,000 -> program natychmiast kończy działanie
                else if (apprawo2 * apq / apliczba == 1)
                {
                    apreszta[aplicznik] = '1';
                    break;
                }
                // zwiększanie licznika, aby nie wyjść poza długośc liczby
                aplicznik++;
            }
            // deklaracja zmiennej, która złączy ze sobą całą resztę (liczby całkowite przed przecinkiem -> 1,324, to 1; 0,242, to 0)
            string apResztaString = "";
            // złączenie ze sobą całej reszty
            for (int i = 0; i < apreszta.Length; i++)
            {
                apResztaString += apreszta[i];
            }
            // zmienna która przechowa całą liczbę binarną
            string apbinarny;
            // zabezpiecznie się na wypadek, gdy liczba binarna przed przecinkiem wyjdzie 0 oraz złączenie ze sobą liczby przed przecinkiem i po przecinku w jedną liczbę
            if (apDwieCzesciLiczbyStalopozycyjnej[0] == "0")
                apbinarny = "0" + ',' + apResztaString;
            else
                apbinarny = aplewo + ',' + apResztaString;
            // wywołanie wyniku
            Console.WriteLine("\n\n\tWynik konwersji: " + apbinarny);
        }
        #endregion

        #region Deklaracja metod pomocniczych dla potrzeb implementacji obu Kalkulatorów
        static void apWczytajLiczbeNaturalna(string apZaproszenieDoPodaniaLiczby, out ushort apn)
        {
            // wypisanie zaproszenia dla podania liczby naturalnej i większej od 0
            Console.Write("\n\t" + apZaproszenieDoPodaniaLiczby + ": ");
            while (!ushort.TryParse(Console.ReadLine(), out apn) || apn < 1)
            {
                // sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w zapisie podanej liczby wystąpił niedozwolony znak");
                // ponowne wypisaie zaproszenia dla podania liczby naturalnej
                Console.Write("\t" + apZaproszenieDoPodaniaLiczby + " ponownie: ");
            }
        }
        static void apWczytajElementCiagu(string apZaproszenieDoPodaniaElementu, out double apelement)
        {
            // wypisanie zaproszenia dla podania elementu ciągu większego od 0
            Console.Write("\n\t" + apZaproszenieDoPodaniaElementu + ": ");
            while (!double.TryParse(Console.ReadLine(), out apelement) || apelement <= 0)
            {
                // sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w zapisie tego wyrazu ciągu liczbowego wystąpił niedozwolony znak ");
                // ponowne zaproszenie dla podania elementu ciągu większego od 0
                Console.Write("\n\tPodaj wartość tego wyrazu ciągu liczbowego ponownie: ");
            }
        }
        // fukcja sortująca
        static string apSort(string apliczba)
        {
            char[] apznaki = apliczba.ToArray();
            Array.Sort(apznaki);
            return new string(apznaki);
        }
        #endregion

    }
}
