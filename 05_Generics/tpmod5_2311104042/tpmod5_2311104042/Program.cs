class Program
{
    static void Main(string[] args)
    {
        // Membuat instance dari HaloGeneric
        HaloGeneric halo = new HaloGeneric();

        // Memanggil method SapaUser dengan input nama
        halo.SapaUser("Tiurma");

        // Bisa juga untuk tipe data lain
        halo.SapaUser(123);
        halo.SapaUser(true);
    }
}
