using System;

public class DoorMachine
{
    public enum State
    {
        Terkunci,
        Terbuka
    }

    private State stateSekarang;

    public DoorMachine()
    {
        stateSekarang = State.Terkunci;
        TampilkanState();
    }

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
