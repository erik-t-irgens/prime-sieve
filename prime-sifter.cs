using System;
using System.Collections.Generic;
using System.Threading;

// business logic

namespace Prime.UserNumber
{
    class Number
    {
        private int _Number;

        public Number(int number)
        {
            _Number = number;
        }
        public void SetNumber(int number)
        {
            _Number = number;
        }

        public int GetUserNumber()
        {
            return _Number;
        }


    }


}