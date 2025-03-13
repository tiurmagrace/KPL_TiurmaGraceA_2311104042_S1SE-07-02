using System;

public class DoorMachine
{
    // Enum untuk mendefinisikan state pintu
    public enum State
    {
        Terkunci,
        Terbuka
    }

    // Menyimpan state saat ini
    private State stateSekarang;

    // Constructor: state awal terkunci
    public DoorMachine()
    {
        stateSekarang = State.Terkunci;
        TampilkanState();
    }

    // Method untuk mengunci pintu
    public void KunciPintu()
    {
        if (stateSekarang == State.Terkunci)
        {
            Console.WriteLine("Pintu sudah dalam keadaan terkunci.");
        }
        else
        {
            stateSekarang = State.Terkunci;
            TampilkanState();
        }
    }

    // Method untuk membuka pintu
    public void BukaPintu()
    {
        if (stateSekarang == State.Terbuka)
        {
            Console.WriteLine("Pintu sudah dalam keadaan terbuka.");
        }
        else
        {
            stateSekarang = State.Terbuka;
            TampilkanState();
        }
    }

    // Method untuk menampilkan state saat ini
    private void TampilkanState()
    {
        if (stateSekarang == State.Terkunci)
        {
            Console.WriteLine("Pintu terkunci");
        }
        else if (stateSekarang == State.Terbuka)
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}
