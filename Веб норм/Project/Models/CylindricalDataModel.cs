using System;

namespace Project.Models
{
    public class CylindricalDataModel
    {
        public double LayerCount {get; set;} //Количество слоёв
        public double TWall { get; set; } //Температура наружной поверхности
        public double TOkr { get; set; } //Температура окружающей среды
        public double TWn { get; set; } //Температура внутренней среды
        public double U { get; set; } //Скорость омывающего потока
        public double R0 { get; set; } //Радиус 0
        public double R1 { get; set; } //Радиус 1
        public double R2 { get; set; } //Радиус 2
        public double R3 { get; set; } //Радиус 3
        public double C1 { get; set; } //Теплопроводности слоёв
        public double C2 { get; set; } //Теплопроводности слоёв
        public double C3 { get; set; } //Теплопроводности слоёв
        public double Position { get; set; } //Расчетные значения при заданном положении поверхности
        public double View { get; set; } //Расчетные значения при заданном виде
        public double Alfa { get; set; } //Расчетные значения при заданном значении альфа
        public double Sloi { get; set; } //Количество слоев

        public void SetDefaultData()
        {

            this.Position = 0;
            this.View = 0;
            this.Alfa = 1;
            this.TOkr = 20;
            this.TWn = 1000;
            this.TWall = 40;
            this.U = 0.1;
            this.R0 = 1;
            this.R1 = 1.2;
            this.R2 = 1.5;
            this.R3 = 1.8;
            this.C1 = 1.7;
            this.C2 = 0.22;
            this.C3 = 2.7;
        }
            public double P()
        {
            if (Position==0) 
            {
                return 0.8;
            }
            if (Position == 1)
            {
                return 0.8;
            }
            else
            {
                return 0.2;
            }
        }
        public double W()
        {
            if (View == 0)
            {
                return 2.4;
            }
            if (View == 1)
            {
                return 3.3;
            }
            else
            {
                return 1.6;
            }
        }
        public double StefBoltsman()
        {
            return 5.668 * Math.Pow(10,-8);
        }
            public double A()
        {
            if (Alfa == 0)
            {
                return Math.Round((Math.Pow (P(), 4) * Math.Sqrt(TWall - TOkr) + ((StefBoltsman() * W() * (Math.Pow((TWall + 273), 4) - Math.Pow((TOkr + 273),4)) / (TWall - TOkr)))));
            }
           
            else
            {
                return Math.Round((0.95 + 0.07 * TWall) * (1.0 + 0.2 * U));
            }
        }
        public double Q
        {
            get
            {
                if (Sloi == 0)
                {
                    return Math.Round((TWn - TOkr) / (1 / (2 * Math.PI * C1) * Math.Log(R1 / R0) + 1 / (2 * Math.PI * C2) * Math.Log(R2 / R1) + 1 / (2 * Math.PI * R2 * A())));
                }

                else
                {
                    return Math.Round((TWn - TOkr) / ((1 / (2 * Math.PI * C1) * Math.Log(R1 / R0)) + (1 / (2 * Math.PI * C2) * Math.Log(R2 / R1)) + (1 / (2 * Math.PI * C3) * Math.Log(R3 / R1)) + 1 / (2 * Math.PI * R2 * A())));
                }
            }
        }
        public double T1
        {
            get
            {
                return Math.Round(TWn - Q/(2*Math.PI*C1)*Math.Log(R1/R0));
            }
        }
        public double T2
        {
            get
            {
                return Math.Round(T1 - Q / (2 * Math.PI * C2) * Math.Log(R2 / R1));
            }
        }
        public double T3
        {
            get
            {
                return Math.Round(T2 - Q / (2 * Math.PI * C3) * Math.Log(R3 / R2));
            }
        }
        public double[] ArrayX;
        public double[] ArrayY;

        public void Graph()
        {
            if (LayerCount == 2)
            {
                ArrayX = new double[2];
                ArrayY = new double[2];

                ArrayX[0] = R1;
                ArrayY[0] = T1;
                ArrayX[1] = R2;
                ArrayY[1] = T2;

            }

            if (LayerCount == 3)
            {
                ArrayX = new double[3];
                ArrayY = new double[3];

                ArrayX[0] = R1;
                ArrayY[0] = T1;
                ArrayX[1] = R2;
                ArrayY[1] = T2;
                ArrayX[2] = R3;
                ArrayY[2] = T3;
            }
        }

    }
}
