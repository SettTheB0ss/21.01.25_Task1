using Task1_21_01_25;
using System;
using System.Buffers;
using System.Data;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа N2");
            Console.WriteLine("1 - 30");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    double e1, y1, f1;
                    Console.WriteLine("Введите значение e");
                    e1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение f");
                    f1 = Convert.ToDouble(Console.ReadLine());
                    Task1 task1 = new Task1(e1, y1, f1);
                    task1.G1();
                    break;

                case 2:
                    double d2, y2;
                    Console.WriteLine("Введите значение d");
                    d2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y2 = Convert.ToDouble(Console.ReadLine());

                    Task2 task2 = new Task2(d2,y2);
                    task2.F2();
                    break;
                case 3:
                    double k3, y3;
                    Console.WriteLine("Введите значение k");
                    k3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y3 = Convert.ToDouble(Console.ReadLine());

                    Task3 task3 = new Task3(k3, y3);
                    task3.U3();
                    break;

                case 4:
                    double w4, y4;
                    Console.WriteLine("Введите значение w");
                    w4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y4 = Convert.ToDouble(Console.ReadLine());

                    Task4 task4 = new Task4(w4, y4);
                    task4.G4();
                    break;

                case 5:
                    double a5, y5, t5;
                    Console.WriteLine("Введите значение a");
                    a5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение t");
                    t5 = Convert.ToDouble(Console.ReadLine());

                    Task5 task5 = new Task5(a5, y5,t5);
                    task5.D5();
                    break;

                case 6:
                    double i6, y6;
                    Console.WriteLine("Введите значение i");
                    i6 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y6 = Convert.ToDouble(Console.ReadLine());

                    Task6 task6 = new Task6(i6, y6);
                    task6.L6();
                    break;

                case 7:
                    double m7, y7;
                    Console.WriteLine("Введите значение m");
                    m7 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y7 = Convert.ToDouble(Console.ReadLine());

                    Task7 task7 = new Task7(y7, m7);
                    task7.N7();
                    break;

                case 8:
                    double t8, y8;
                    Console.WriteLine("Введите значение t");
                    t8 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y8 = Convert.ToDouble(Console.ReadLine());

                    Task8 task8 = new Task8(y8, t8);
                    task8.T();
                    break;
                
                case 9: 
                    double y9,w9;
                    Console.WriteLine("Введите значение w");
                    w9 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y9 = Convert.ToDouble(Console.ReadLine());

                    Task9 task9 = new Task9(y9, w9);
                    task9.V();
                    break;

                case 10:
                    double t10, y10; ;
                    Console.WriteLine("Введите значение t");
                    t10 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y10 = Convert.ToDouble(Console.ReadLine());

                    Task10 task10 = new Task10(t10, y10);
                    task10.Z();
                    break;
                
                case 11:
                    double n11, y11; ;
                    Console.WriteLine("Введите значение n");
                    n11 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y11 = Convert.ToDouble(Console.ReadLine());

                    Task11 task11 = new Task11(n11, y11);
                    task11.D();
                    break;

                case 12:
                    double t12, y12; ;
                    Console.WriteLine("Введите значение t");
                    t12 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y12 = Convert.ToDouble(Console.ReadLine());

                    Task12 task12 = new Task12(t12, y12);
                    task12.R();
                    break;

                case 13:
                    double n13, y13; ;
                    Console.WriteLine("Введите значение h");
                    n13 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y13 = Convert.ToDouble(Console.ReadLine());

                    Task13 task13 = new Task13(n13, y13);
                    task13.A();
                    break;

                case 14:
                    double n14, y14; ;
                    Console.WriteLine("Введите значение h");
                    n14 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y14 = Convert.ToDouble(Console.ReadLine());

                    Task14 task14 = new Task14(n14, y14);
                    task14.P();
                    break;

                case 15:
                    double j15, y15; ;
                    Console.WriteLine("Введите значение j");
                    j15 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y15 = Convert.ToDouble(Console.ReadLine());

                    Task15 task15 = new Task15(j15, y15);
                    task15.F();
                    break;

                case 16:
                    double r16, y16; ;
                    Console.WriteLine("Введите значение r");
                    r16 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y16 = Convert.ToDouble(Console.ReadLine());

                    Task16 task16 = new Task16(r16, y16);
                    task16.W();
                    break;

                case 17:
                    double n17, y17; ;
                    Console.WriteLine("Введите значение r");
                    n17 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y17 = Convert.ToDouble(Console.ReadLine());

                    Task17 task17 = new Task17(n17, y17);
                    task17.H();
                    break;

                case 18:
                    double k18, y18; ;
                    Console.WriteLine("Введите значение k");
                    k18 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y18 = Convert.ToDouble(Console.ReadLine());

                    Task18 task18 = new Task18(k18, y18);
                    task18.R();
                    break;

                case 19:
                    double q19, y19; ;
                    Console.WriteLine("Введите значение q");
                    q19 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y19 = Convert.ToDouble(Console.ReadLine());

                    Task19 task19 = new Task19(q19, y19);
                    task19.E();
                    break;

                case 20:
                    double k20, y20,l20;
                    Console.WriteLine("Введите значение k");
                    k20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение l");
                    l20 = Convert.ToDouble(Console.ReadLine());

                    Task20 task20 = new Task20(k20, y20,l20);
                    task20.K();
                    break;

                case 21:
                    double k21, y21, d21;
                    Console.WriteLine("Введите значение k");
                    k21 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y21 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение l");
                    d21 = Convert.ToDouble(Console.ReadLine());

                    Task21 task21 = new Task21(k21, y21, d21);
                    task21.K();
                    break;

                case 22:
                    double t22, y22;
                    Console.WriteLine("Введите значение k");
                    t22 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y22 = Convert.ToDouble(Console.ReadLine());

                    Task22 task22 = new Task22(t22, y22);
                    task22.S();
                    break;

                case 23:
                    double d23, y23;
                    Console.WriteLine("Введите значение k");
                    d23 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y23 = Convert.ToDouble(Console.ReadLine());

                    Task23 task23 = new Task23(d23, y23);
                    task23.R();
                    break;

                case 24:
                    double k24, y24;
                    Console.WriteLine("Введите значение k");
                    k24 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y24 = Convert.ToDouble(Console.ReadLine());

                    Task24 task24 = new Task24(k24, y24);
                    task24.U();
                    break;

                case 25:
                    double c25, t25;
                    Console.WriteLine("Введите значение c");
                    c25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    t25 = Convert.ToDouble(Console.ReadLine());

                    Task25 task25 = new Task25(c25, t25);
                    task25.L();
                    break;

                case 26:
                    double u26, y26;
                    Console.WriteLine("Введите значение u");
                    u26 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y26 = Convert.ToDouble(Console.ReadLine());

                    Task26 task26 = new Task26(y26, u26);
                    task26.T();
                    break;

                case 27:
                    double p27, y27;
                    Console.WriteLine("Введите значение p");
                    p27 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y27 = Convert.ToDouble(Console.ReadLine());

                    Task27 task27 = new Task27(p27, y27);
                    task27.Z();
                    break;

                case 28:
                    double v28, y28;
                    Console.WriteLine("Введите значение v");
                    v28 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y28 = Convert.ToDouble(Console.ReadLine());

                    Task28 task28 = new Task28(v28, y28);
                    task28.Z();
                    break;

                case 29:
                    double h29, y29;
                    Console.WriteLine("Введите значение h");
                    h29 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y29 = Convert.ToDouble(Console.ReadLine());

                    Task29 task29 = new Task29(h29, y29);
                    task29.Z();
                    break;

                case 30:
                    double p30, y30;
                    Console.WriteLine("Введите значение p");
                    p30 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y30 = Convert.ToDouble(Console.ReadLine());

                    Task30 task30 = new Task30(p30, y30);
                    task30.Z();
                    break;

            }

        }
    }
}
