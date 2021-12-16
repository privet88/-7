using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_5
{
    public class Triad
    {
        int _one;//первое число
        int _second;//второе число
        int _third;//третье число
        public int One //Первое число
        {
            get
            {
                return _one;
            }
            set
            {
                _one = value;
                
            }
        }
                
        public int Second //Второе число
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
                
            }
        }
        public int Third //Третье число
        {
            get
            {
                return _third;
            }
            set
            {
                _third = value;
                
            }
        }
       

        public static Triad operator ++(Triad c1)
        {
            Triad rezult = new Triad();
            rezult.One = c1.One + 1;
            rezult.Second = c1.Second + 1;
            rezult.Third = c1.Third + 1;
            return rezult;
        }
        public static int operator +(Triad c1,int val )
        {
            int rezult;
            rezult= c1.One + c1.Second+c1.Third+val;
            return rezult;
        }
        public void SetParams()
        {
                One = One + 10;
                Second = Second + 10;
                Third = Third + 10;
               
            
        }
        public void SetParams(int One, int Second, int Third)
        {
           
                One= _one;
            Second = _second;
            Third = _third;
            
        }
       
    }
    public class Date : Triad
    {
        public void Increment()
        {
            int n;
            if (Second % 2 != 0 || Second == 7)
            {
                One = One + 1;
                if (One > 31)
                {
                    n = One - 31;
                    One = 0;
                    One = One + n;
                    Second = Second + 1;

                    
                    if (Second >= 12)
                    {
                        Second = 0;
                        Second = Second + 1;
                        Third = Third + 1;
                    }
                    else Third = Third + 1;
                }
                else
                {
                    Second = Second + 1;
                }

            }
            else
                if (One > 30)
            {
                n = One - 30;
                One = 0;
                One = One + n;
                Second = Second + 1;

                if (Second >= 12)
                {
                    Second = 0;
                    Second = Second + 1;
                    Third = Third + 1;
                }
                else Third = Third + 1;
            }
            else
            {
                Second = Second + 1;
            }
        }
        public void ChangeDate(int n)
        {

            if (Second % 2 != 0 || Second == 7)
            {
                One = One + n;
                if (One > 31)
                {
                    n = One - 31;
                    One = 0;
                    One = One + n;
                    Second = Second + 1;

                    if (Second >= 12)
                    {
                        Second = 0;
                        Second = Second + 1;
                        Third = Third + 1;
                    }
                }
               
            }
            else
                 if (One > 30)
            {
                n = One - 30;
                One = 0;
                One = One + n;
                Second = Second + 1;

                if (Second >= 12)
                {
                    Second = 0;
                    Second = Second + 1;
                    Third = Third + 1;
                }
            }
            
        }
    }
}
