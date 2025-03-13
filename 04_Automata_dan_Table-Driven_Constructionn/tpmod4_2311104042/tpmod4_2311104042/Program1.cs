using System;

class Program1
{
    static void Main(string[] args)
    {
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();  
        pintu.KunciPintu(); 
        pintu.KunciPintu(); 
        pintu.BukaPintu();  
        pintu.BukaPintu();  
    }
}
