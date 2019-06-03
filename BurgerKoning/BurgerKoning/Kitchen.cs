using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKoning
{
    public class Kitchen
    {
        private int _amountMeat;
        private int _amountBuns;

        private Queue<Hamburger> hamburgers = new Queue<Hamburger>();

        public int getAmountHamburgers()
        {
            return hamburgers.Count;
        }
        public int getAmountMeat()
        {
            return _amountMeat;
        }
        public int getAmountBuns()
        {
            return _amountBuns;
        }

        public void addMeat()
        {
            _amountMeat++;
        }

        public void addBun()
        {
            _amountBuns++;
        }

        public void makeHamburger()
        {
            if (_amountMeat > 0 && _amountBuns > 0)
            {
                _amountMeat--;
                _amountBuns--;
                Hamburger h = new Hamburger();
                hamburgers.Enqueue(h);
            }
        }

        public void removeHamburger()
        {
            hamburgers.Dequeue();
        }
    }
}
