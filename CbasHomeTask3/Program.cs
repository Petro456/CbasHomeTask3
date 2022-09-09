using System;

namespace CbasHomeTask3
{
    class ClassRoom
    {
        Pupil ychenik1;
        Pupil ychenik2;
        Pupil ychenik3;
        Pupil ychenik4;
        Pupil[] ycheniks = new Pupil[4];
        public ClassRoom(Pupil ychenik1, Pupil ychenik2, Pupil ychenik3, Pupil ychenik4)
        {
            this.ychenik1 = ychenik1;
            this.ychenik2 = ychenik2;
            this.ychenik3 = ychenik3;
            this.ychenik4 = ychenik4;
            Console.WriteLine(new String('/', 80));
            Console.WriteLine($"1 учень  {ychenik1.Study()}, {ychenik1.Read()}, {ychenik1.Write()}, {ychenik1.Relax()}");
            Console.WriteLine($"2 учень  {ychenik2.Study()}, {ychenik2.Read()}, {ychenik2.Write()}, {ychenik2.Relax()}");
            Console.WriteLine($"3 учень  {ychenik3.Study()}, {ychenik3.Read()}, {ychenik3.Write()}, {ychenik3.Relax()}");
            Console.WriteLine($"4 учень  {ychenik4.Study()}, {ychenik4.Read()}, {ychenik4.Write()}, {ychenik4.Relax()}");
            Console.WriteLine( new String('/',80));

            ycheniks[0] = this.ychenik1;
            ycheniks[1] = this.ychenik2;
            ycheniks[2] = this.ychenik3;
            ycheniks[3] = this.ychenik4;

        }
        public ClassRoom(Pupil ychenik1, Pupil ychenik2, Pupil ychenik3)
        {
            this.ychenik1 = ychenik1;
            this.ychenik2 = ychenik2;
            this.ychenik3 = ychenik3;

            Console.WriteLine($"1 учень  {ychenik1.Study()}, {ychenik1.Read()}, {ychenik1.Write()}, {ychenik1.Relax()}");
            Console.WriteLine($"2 учень  {ychenik2.Study()}, {ychenik2.Read()}, {ychenik2.Write()}, {ychenik2.Relax()}");
            Console.WriteLine($"3 учень  {ychenik3.Study()}, {ychenik3.Read()}, {ychenik3.Write()}, {ychenik3.Relax()}");
            Console.WriteLine($"Про  4 - го учня нiчого не вiдомо");
            Console.WriteLine(new String('/', 80));

            ycheniks[0] = ychenik1;
            ycheniks[1] = ychenik2;
            ycheniks[2] = ychenik3;
        }
    }
     abstract class Pupil
    {
        public abstract string Study();
        public abstract string Read();
        public abstract string Write();
        public abstract string Relax();        
    }
    class ExcelentPupil : Pupil
    {
        public override string Study()
        {
            return "вчиться вiдмiнно";
        }
        public override string Read()
        {
            return "читає вiдмiнно";
        }
        
        public override string Write()
        {
            return "пише вiдмiнно";
        }
        public override string Relax()
        {
            return "вiдпочиває вiдмiнно";
        }

    }
    class GoodPupil : Pupil
    {
        public override string Study()
        {
            return "вчиться добре";
        }
        public override string Read()
        {
            return "читає добре";
        }
        public override string Write()
        {
            return "пише добре";
        }
        public override string Relax()
        {
            return "вiдпочиває добре";
        }
    }
    class BadPupil : Pupil
    {
        public override string Study()
        {
            return "вчиться погано";
        }
        public override string Read()
        {
            return "читає погано";
        }
        public override string Write()
        {
            return "пише погано";
        }
        public override string Relax()
        {
            return "вiдпочиває погано";
        }
    }


    internal class Program
    {
        /*Задание 2 

                Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс,
        представляющий учебный класс ClassRoom. Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), 
        void Relax(). Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов,
        в зависимости от успеваемости ученика. Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
        Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. Выведите информацию о том, 
        как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. */



        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil good=new GoodPupil();
            BadPupil bad=new BadPupil();

            ClassRoom classRoom1 = new ClassRoom(excelentPupil, good, bad, bad);

            ClassRoom classRoom2 = new ClassRoom(excelentPupil, good, bad);

            Console.ReadKey();

        }
    }
}
