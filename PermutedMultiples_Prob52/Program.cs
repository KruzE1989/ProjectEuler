using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermutedMultiples_Prob52
{
    class Program
    {
        static void Main(string[] args)
        {
            long _x = 1, _2x, _3x , _4x , _5x , _6x;
            long _xO , _2xO, _3xO, _4xO, _5xO, _6xO;
            char[] tmp;
            bool flag = true;
            while (flag)
            {
                _2x = 2 * _x;
                _3x = 3 * _x;
                _4x = 4 * _x;
                _5x = 5 * _x;
                _6x = 6 * _x;

                tmp = _x.ToString().ToArray();
                Array.Sort(tmp);
                _xO = Convert.ToInt32(new string(tmp));
                tmp = _2x.ToString().ToArray();
                Array.Sort(tmp);
                _2xO = Convert.ToInt32(new string(tmp));
                tmp = _3x.ToString().ToArray();
                Array.Sort(tmp);
                _3xO = Convert.ToInt32(new string(tmp));
                tmp = _4x.ToString().ToArray();
                Array.Sort(tmp);
                _4xO = Convert.ToInt32(new string(tmp));
                tmp = _5x.ToString().ToArray();
                Array.Sort(tmp);
                _5xO = Convert.ToInt32(new string(tmp));
                tmp = _6x.ToString().ToArray();
                Array.Sort(tmp);
                _6xO = Convert.ToInt32(new string(tmp));


                if (_xO == _2xO && _2xO == _3xO && _3xO == _4xO && _4xO== _5xO && _5xO == _6xO)
                    flag = false;
                else
                    _x++;
            }
            Console.WriteLine(_x);
        }
    }
}
