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
        private int _charCount;
        private const double inkForOneChar = 0.05;
        
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
                if (value >= 0 && value <= MaxInk)
                    _inkLevel = value;
                else if (value < 0)
                {
                    _inkLevel = 0;
                    throw new Exception("You can't write anymore! Ink finished!");
                }
                else if (value > MaxInk)
                {
                    _inkLevel = MaxInk;
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
        
        public int CharCount
        {
            get
            {
                return _charCount;
            }
            set
            {
                _charCount = value;
            }
        }

        // Default Constructor
        public Pen()
        {
            Brand = "bic";
            Colour = "Black";
            MaxInk = 10;
            HasLid = true;
            InkLevel = MaxInk;
        }

        // Greedy Constructor
        public Pen(string brand, string colour, double maxInk, double inkLevel, bool hasLid)
        {
            Brand = brand;
            Colour = colour;
            MaxInk = maxInk;            
            InkLevel = inkLevel;
            HasLid = hasLid;
        }

        public void Write()
        {
            CharCount = 10;
            InkLevel -= inkForOneChar * CharCount;
        }

        public void Write( int charCount )
        {
            CharCount = charCount;
            InkLevel -= (inkForOneChar * CharCount);
        }
        
        public string LidStatus()
        {
            string lid;
            lid = HasLid ? "with" : "without";
            return lid;
        }

        public int InkPercent()
        {
            int roundedInkPercent;
            double inkPercent;
            inkPercent = (InkLevel / MaxInk) * 100;
            roundedInkPercent = (int)Math.Round(inkPercent / 5) * 5;
            return roundedInkPercent;
        }
        
        public override string ToString()
        {
            return "This is a "+ Colour + " " + Brand  + " pen "+ LidStatus() +  " a lid with approximately " +  InkPercent() + "% of the ink remaining.";
        }
    }
}
