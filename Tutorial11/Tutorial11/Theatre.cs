using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial11
{
    public class Theatre
    {
        private bool _completelyVacant;
        private int _currentVacantSeats;
        private string _lastBookedSeatDetails;
        private string _theatreAddress;
        private string _theatreName;
        private int _totalSeatsinTheatre;
        private Seat[,] _seats;

        public Theatre(string myName, string myAddress)
        {
            _theatreName = myName;
            _theatreAddress = myAddress;
            InitializeSeats();
        }

        public int CurrentVacantSeats
        {
            get
            {
                return _currentVacantSeats;
            }
        }

        public string DetailsOfLastBooking
        {
            get
            {
                return _lastBookedSeatDetails;
            }
        }

        public bool IsCompleteVacant
        {
            get
            {
                return _completelyVacant;
            }
        }

        public string TheatreAddress
        {
            get
            {
                return _theatreAddress;            }
        }

        public string TheatreName
        {
            get
            {
                return _theatreName;
            }
        }

        public void InitializeSeats()
        {
            _completelyVacant = true;
            _currentVacantSeats = 60;
            _totalSeatsinTheatre = 60;
            _lastBookedSeatDetails = "";

            _seats = new Seat[,]
            {
                { new Seat('A', 1), new Seat('A', 2), new Seat('A', 3), new Seat('A', 4), new Seat('A', 5), new Seat('A',
                6), new Seat('A', 7), new Seat('A', 8), new Seat('A', 9), new Seat('A', 10)},
                { new Seat('B', 1), new Seat('B', 2), new Seat('B', 3), new Seat('B', 4), new Seat('B', 5), new Seat('B',
                6), new Seat('B', 7), new Seat('B', 8), new Seat('B', 9), new Seat('B', 10)},
                { new Seat('C', 1), new Seat('C', 2), new Seat('C', 3), new Seat('C', 4), new Seat('C', 5), new Seat('C',
                6), new Seat('C', 7), new Seat('C', 8), new Seat('C', 9), new Seat('C', 10)},
                { new Seat('D', 1), new Seat('D', 2), new Seat('D', 3), new Seat('D', 4), new Seat('D', 5), new Seat('D',
                6), new Seat('D', 7), new Seat('D', 8), new Seat('D', 9), new Seat('D', 10)},
                { new Seat('E', 1), new Seat('E', 2), new Seat('E', 3), new Seat('E', 4), new Seat('E', 5), new Seat('E',
                6), new Seat('E', 7), new Seat('E', 8), new Seat('E', 9), new Seat('E', 10)},
                { new Seat('F', 1), new Seat('F', 2), new Seat('F', 3), new Seat('F', 4), new Seat('F', 5), new Seat('F',
                6), new Seat('F', 7), new Seat('F', 8), new Seat('F', 9), new Seat('F', 10)}

            };
        }

        public string PleaseBookSeats(int NumberOfSeats)
        {
            int bookedNumber = 0;

            if(NumberOfSeats > _totalSeatsinTheatre)
            {
                return "Booking cannt more than 60.";
            }else if(NumberOfSeats > _currentVacantSeats)
            {
                return "There is no enough seats.";
            }else
            {
                for(int row = 0; row < 6; row++)
                {
                    for(int seat = 0; seat < 10; seat ++)
                    {
                        _seats[row, seat].IsVacant = false;
                        _completelyVacant = false;
                        _currentVacantSeats--;
                        bookedNumber++;
                        _lastBookedSeatDetails = _lastBookedSeatDetails + _seats[row, seat].RowNumber
                            + _seats[row, seat].SeatNumber + " booked ";
                        if(bookedNumber == NumberOfSeats)
                        {
                            return "Booked " + NumberOfSeats + " seats";
                        }
                    }
                }
                return "Error";
            }
/*
            if (NumberOfSeats <= 0)
            {
                _lastBookedSeatDetails = "invalid order number";
                return _lastBookedSeatDetails;
            }

            if (NumberOfSeats > _currentVacantSeats)
            {
                _lastBookedSeatDetails = "There is no enough seats.";
                return _lastBookedSeatDetails;
            }

            //if (NumberOfSeats > 60)
            //{
            //    _lastBookedSeatDetails = "Booking cannt more than 60.";
            //    return _lastBookedSeatDetails;
            //}

            
            foreach (Seat seat in _seats)
            {
                if (seat.IsVacant)
                {
                    _lastBookedSeatDetails = _lastBookedSeatDetails + seat.RowNumber.ToString() + seat.SeatNumber.ToString() + " Booked\n";
                    seat.IsVacant = false;
                    if (_currentVacantSeats > 0)
                    {
                        --_currentVacantSeats;
                    }
                    ++bookedNumber;
                    if (bookedNumber == NumberOfSeats)
                    {
                        break;
                    }
                }
            }
            if (_currentVacantSeats < _totalSeatsinTheatre)
            {
                _completelyVacant = false;
            }
            return _lastBookedSeatDetails;
            */
        }

        public void ResetAllSeatsForNewShow()
        {
            _lastBookedSeatDetails = "";
            _currentVacantSeats = 60;
            _completelyVacant = true;
            foreach(Seat s in _seats)
            {
                s.IsVacant = true;
            }

        }
    }
}
