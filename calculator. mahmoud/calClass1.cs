using System;
using System.Collections.Generic;
using System.Text;



namespace calculator.mahmoud
{ 
   internal class calClass1
    {

      
            public double sum(double a, double b)
            {
                return a + b;

            }
            public double sub(double a, double b)
            {
                return a - b;

            }
            public double multi(double a, double b)
            {
                return a * b;
            }
            public double div(double a, double b)
            {
                return a / b;
            }
             public double Percentage(double total, double part)
            {
               

               return (total * part) /100 ;
            }
            

      
    }
}