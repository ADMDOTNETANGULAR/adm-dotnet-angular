﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.DIP
{

    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }
    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }
    public class SUV : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }
    public class AutomobileController
    {
        IAutomobile m_Automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }

        public void Ignition()
        {
            m_Automobile.Ignition();
        }

        public void Stop()
        {
            m_Automobile.Stop();
        }
    }
    internal class Demo2
    {
        static void Main(string[] args)
        {
            //IAutomobile automobile = new Jeep();
            IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();

            Console.Read();
        }
    }
}
