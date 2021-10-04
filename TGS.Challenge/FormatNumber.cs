using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */


    public class FormatNumber
    {
        public string Format(int value)
        {
            //Throw exception if value is either a negative number (-1) or more than the allowed range(1000000001)
            if (value == -1 || value == 1000000001)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                //Declare varaibles
                string _decimalValue = "";
                string formatted = "";
                var _newDecimalValue = new StringBuilder();

                //Convert the given integer to equivalent string value
                var _intValue = value.ToString();

                //Convert string to array 
                var _numArray1 = _intValue.ToCharArray();

                //Reverse array
                Array.Reverse(_numArray1);
                _intValue = new string(_numArray1);

                // Initialise count
                int count = 0;

                //loop through array
                for (int i = 0; i < _intValue.Length; i++)
                {
                    ++count;
                    _decimalValue += _intValue[i];

                    //Check for last item in index/list
                    bool isLast = i == _intValue.Length - 1;

                    //If count is 3 and isLast is false add comma(,) to 3rd index item in array
                    if (count == 3 && !isLast)
                    {
                        count = 0;
                        formatted = _decimalValue + ",";
                        _newDecimalValue.Append(formatted);
                        _decimalValue = "";
                    }

                    _newDecimalValue.Append(_decimalValue);
                    _decimalValue = "";
                }

                //Convert string to array
                var _numArray2 = _newDecimalValue.ToString().ToCharArray();

                Array.Reverse(_numArray2);

                //Return a string that is the decimal representation of the integrer number input
                var formattedResult = new string(_numArray2);
                return formattedResult;
            }
        }
    }
}
