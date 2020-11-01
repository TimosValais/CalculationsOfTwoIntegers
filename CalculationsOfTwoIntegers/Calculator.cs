using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsOfTwoIntegers
{
    class Calculator
    {
        int x;
        int y;
        bool isOverloaded = false;

        // business logic
        // new Calculator(); <-- x = 0, y = 1 default constructor
        public Calculator()
        {
            isOverloaded = false;
            //this.x = 0;
            //this.y = 0;
        }

        // new Calculator(10, 20); overloaded constructor
        // new Caclulator(10, 0); <--- do not crash
        public Calculator(int x, int y)
        {
            isOverloaded = true;
            //this.x = x;
            //this.y = y;
            //this.AssignFieldValues(x, y, false, true, );
        }

        private void AssignFieldValues(int x, int y, bool dontUseZero, bool isOverLoaded, bool methodOverloaded)
        {
            /*
             * const        values (x,y)     methods   result(add)   result(divide)
             * A ()           0,0              ()       A1 0 + 0       A2 0 / 1
             * B ()           0,0              (x, y)   B1 x + y       B2 x / (y = 1)
             * C (x, y)       x,y              ()       B1 x + y       B2 x / (y = 1)
             * D (x, y)       x,y              (i,j)    D1 i + j       D2 i / (j = 1)
             * E (x, y == 0)  x,y              ()       B1 x + y       B2 x / (y = 1)  
             * 
             * 
             * 1st case = A1
             * 2st case = A2
             * 3nd case = B1
             * 4th case = B2
             * 5th case = D1
             * 6th case = D2
             * 
             */

            switch (isOverLoaded )
            {
                case false:
                    if (methodOverloaded == false && dontUseZero == true)
                    {
                        this.x = 0;
                        this.y = 1;
                    }
                    else if(methodOverloaded == false && dontUseZero == false)
                    {
                        this.x = 0;
                        this.y = 0;
                    }
                    else if (methodOverloaded == true && dontUseZero == true)
                    {
                        this.x = x;
                        this.y = 1;
                    }
                    else
                    {
                        this.x = x;
                        this.y = y;
                    }
                    break;
                case true:
                    if (methodOverloaded == true && dontUseZero == true)
                    {
                        this.x = x;
                        this.y = 1;
                    }
                    else if(methodOverloaded == true && dontUseZero == false)
                    {
                        this.x = x;
                        this.y = y;
                    }
                    else if(methodOverloaded == false && dontUseZero == true)
                    {
                        x = this.x;
                        this.y = 1;
                    }
                    else if (methodOverloaded == false && dontUseZero == false)
                    {
                        x = this.x;
                        y = this.y;
                    }
                    break;
                
            }
            //switch (isOverLoaded)
            //{
            //    case true:
            //        if(dontUseZero == true && methodOverloaded == true)
            //        {
            //            this.x = x;
            //            this.y = 1;
            //        }
            //        else if(dontUseZero == true && methodOverloaded == false)
            //        {
            //            this.x = x;
            //            this.y = 1;
            //        }
            //        else if(dontUseZero == false && methodOverloaded == false)
            //        {
            //            this.x = x;
            //            this.y = y;
            //        }
            //        else
            //        {
            //            this.x = x;
            //            this.y = y;
            //        }
            //        break;
            //    default:
            //        if (dontUseZero == true)
            //        {
            //            this.x = 0;
            //            this.y = 1;
            //        }
            //        else
            //        {
            //            this.x = 0;
            //            this.y = 0;
            //        }

            //        break;
            //}

            //this.x = x;
            //if (y == 0 && dontUseZero)
            //{
            //    this.y = 1;
            //}
            //else
            //{
            //    this.y = y;
            //}
        }

        // Add(); / Subtract(); / Multiply(); / Divide();
        public int Add()
        {
            this.AssignFieldValues(this.y, this.x, false, false, false);
            return (this.x + this.y);
        }

        public int Add(int x, int y)
        {
            this.AssignFieldValues(x, y, false, true, true);
            return (this.x + this.y);
        }

        public int Subtract()
        {
            this.AssignFieldValues(this.x, this.y, false, false, false);
            return (this.x - this.y);
        }

        public int Subtract(int x, int y)
        {
            this.AssignFieldValues(x, y, false, true, true);
            return (this.x - this.y);
        }

        public int Multiply()
        {
            this.AssignFieldValues(this.x, this.y, false, false, false);
            return (this.x * this.y);
        }

        public int Multiply(int x, int y)
        {
            this.AssignFieldValues(x, y, false, true, true);
            return (this.x * this.y);
        }

        public int Divide()
        {
            this.AssignFieldValues(this.x, this.y, true, false, false);
            return (this.x / this.y);
        }

        public int Divide(int x, int y)
        {
            this.AssignFieldValues(x, y, true, false, true);
            return (this.x / this.y);
        }

        // < new Calculator(10, 20); / new Calculator(); >

        // Add(10,20); / Subtract(10,20); / Multiply(10,20); / Divide(10,20);
        // < new Calculator(100, 200); / new Calculator(); >

        public void TellMePleaseTheValuesOfTheFields()
        {
            Console.WriteLine($"{x}, {y}");
        }
    }
}
