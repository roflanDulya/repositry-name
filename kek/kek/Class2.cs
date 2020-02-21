using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kek
{
    class Class2
    {
        public double _PChislo;
        public double _VChislo;
        private double Sum(double a, double b)
        {
            return a + b; // возвращает сумму
        }
        private double Min(double a, double b)
        {
            return a - b; // возвращает сумму
        }
        private double Ymn(double a, double b)
        {
            return a * b; // возвращает сумму
        }
        private double Del(double a, double b)
        {
            return a / b; // возвращает деление
        }
        private double Step(double a, double b)
        {
            return System.Math.Pow(a,b); // возвращение квадрата
        }
        private double Kor(double a)
        {
            return System.Math.Sqrt(a); // возвращение квадрата
        }
        public double Proc(double a,double b)
        {
            return (b / 100) * a;
        }
        public double Log(double a)
        {
            return System.Math.Log10(a);
        }
        public double Summa // метод будет получать значения которые мы получили на в закрытом методе sum
        {
            get { return Sum(PChislo, VChislo); }
        }
        public double Vichetane // метод будет получать значения которые мы получили на в закрытом методе Min
        {
            get { return Min(PChislo, VChislo); }
        }
        public double Ymnojenie // метод будет получать значения которые мы получили на в закрытом методе Ymn
        {
            get { return Ymn(PChislo, VChislo); }
        }
        public double Delenie // метод будет получать значения которые мы получили на в закрытом методе Del
        {
            get { return Del(PChislo, VChislo); }
        }
        public double Stepen
        {
            get { return Step(PChislo, VChislo); }
        }

        public double Koren
        {
            get { return Kor(PChislo); }
        }
        public double Procent
        {
            get { return Proc(PChislo,VChislo); }
        }
        public double Logarifm
        {
            get { return Log(PChislo); }
        }
        public double PChislo
        {
            get { return _PChislo; } // возвращает значение первого числа
            set { _PChislo = value; }
        }
        public double VChislo
        {
            get { return _VChislo; } // возвращает значение второго числа
            set { _VChislo = value; }
        }
    }   
}