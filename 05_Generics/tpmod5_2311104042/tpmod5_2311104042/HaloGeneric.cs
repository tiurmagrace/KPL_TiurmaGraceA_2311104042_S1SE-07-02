using System;

// Class dengan Generic Method
class HaloGeneric
{
    // Method generic untuk menyapa user
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}
