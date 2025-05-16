namespace adapter_dp
{
    public interface IAmericanPlug
    {
        void PlugIn();
    }

    public class IndonesianPlug
    {
        public void Sambungkan()
        {
            Console.WriteLine("Colokan Indonesia tersambung");
        }
    }

    public class PlugAdaptor : IAmericanPlug
    {
        private readonly IndonesianPlug _plug;
        public PlugAdaptor(IndonesianPlug indonesianPlug)
        {
            _plug = indonesianPlug;
        }

        public void PlugIn()
        {
            Console.WriteLine("Menggunakan adapter colokan indonesia ke amerika");
            _plug.Sambungkan();
        }
    }
}
