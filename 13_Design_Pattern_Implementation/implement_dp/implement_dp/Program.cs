﻿using singleton_dp;
using adapter_dp;
using command_dp;

namespace design_pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========Singleton========");
                Rektor rektor1 = Rektor.GetRektor();
                Rektor rektor2 = Rektor.GetRektor();

            if (rektor1 == rektor2)
            {
                Console.WriteLine("Rektor sama");
            }
            else
            {
                Console.WriteLine("Rektor berbeda");
            }

            rektor1.Tandatangan();

            Console.WriteLine("\n=============Adapter===========");

            IndonesianPlug indonesianPlug = new IndonesianPlug();
            IAmericanPlug adaptor = new PlugAdaptor(indonesianPlug);
            adaptor.PlugIn();

            Console.WriteLine("\n==========Command==============");

            RemoteTv remote = new RemoteTv();

            Television tv = new Television();

            TelevisionTurnOn turnOn = new TelevisionTurnOn(tv);
            TelevisionTurnOff turnOff = new TelevisionTurnOff(tv);

            remote.setTurnOn(turnOn);
            remote.setTurnOff(turnOff);
            remote.TurnOnTV();
            remote.TurnOffTV();
        }
    }
}