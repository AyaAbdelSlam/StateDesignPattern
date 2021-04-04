using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class Uncooked:Doneness
    {
        public Uncooked(Doneness state)
        {
            currentTemp = state.CurrentTemp;
            steak = state.Steak;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 0;
            upperTemp = 130;
            canEat = false;
        }

        public override void AddTemp(double amount)
        {
            currentTemp += amount;
            DonenessCheck();
        }

        public override void RemoveTemp(double amount)
        {
            currentTemp -= amount;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp > upperTemp)
            {
                steak.State = new Rare(this);
            }
        }
    }
}
