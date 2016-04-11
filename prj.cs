using System.IO;
using System;

class Program
{
    /// <summary>
    ///  To jest główna metoda programu sprawdzajaca po kolei liczby w celu odnalezienia
    ///  danej ilości liczb pierwszych
    /// </summary>
    static void Main()
    {
        int countPrime=0;
        int lastNumber=1;
        while(countPrime<10001){
            lastNumber++;
            if(isPrime(lastNumber))countPrime++;
        }
        Console.WriteLine("Last Prime: {0}",lastNumber);
    }
    
    /// <summary>
    ///  Metoda isPrime sprawdza czy liczba jest pierwsza
    /// </summary>
    ///  <param name="number">liczba ktora chcemy sprawdzic</param>
    static bool isPrime(double number)
    {
        int count=0;
        
        for(int i=1;i<=number;i++){
            if(restFromDivide(number,i*1.0)==0)count++;
            if(count>2)return false;
        }
        return true;
    }
    
    /// <summary>
    ///  Metoda restFromDivide zwraca reszte z dzielenia
    /// </summary>
    ///  <param name="dividend">dzielna</param>
    ///  <param name="divider">dzielnik</param>
    static double restFromDivide(double dividend, double divider){
        double buffDouble;
        int buffInteger;
        
        buffDouble = dividend/divider;
        buffInteger = (int)buffDouble;
        return buffDouble-buffInteger;
    }
}
