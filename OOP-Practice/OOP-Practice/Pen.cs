using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class Pen
    {
        private string _brandName;
        private string _colour;
        private double _inkLevel;
        private double _maxInk;
        private bool _hasLid;

        public string Brand 
        {
            get 
            {
                return _brandName;
            }
            set 
            {
                _brandName = value;
            } 
        }

        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }

        public double MaxInk
        {
            get
            {
                return _maxInk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Maximum Ink Level should be greater than 0");
                }
                _maxInk = value;
            }
        }

        public double InkLevel
        {
            get
            {
                return _inkLevel;
            }
            set
            {
                if( value >0 && value <= MaxInk )
                _inkLevel = value;
                else
                {
                    throw new Exception("Ink Level should be between 0 and Maximum Ink Level");
                }
            }
        }        

        public bool HasLid
        {
            get
            {
                return _hasLid;
            }
            set
            {
                _hasLid = value;
            }
        }


    }
}
