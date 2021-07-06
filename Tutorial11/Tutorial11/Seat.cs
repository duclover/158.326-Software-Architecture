using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial11
{
    public class Seat
    {
        private char _myRowNumber;
        private int _mySeatNumber;
        private bool _isVavant;
        public Seat(char myRowNumber, int mySeatNumber)
        {
            //throw new System.NotImplementedException();
            _myRowNumber = myRowNumber;
            _mySeatNumber = mySeatNumber;
            _isVavant = true;
        }

        public bool IsVacant
        {
            get
            {
                return _isVavant;
            }
            set
            {
                _isVavant = value;
            }
        }

        public char RowNumber
        {
            get
            {
                return _myRowNumber;
            }
        }

        public int SeatNumber
        {
            get
            {
                return _mySeatNumber;
            }
        }
    }
}