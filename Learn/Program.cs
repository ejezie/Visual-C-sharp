using System;

namespace Learn
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //Console.WriteLine(FeetToInches(4));
            //Console.WriteLine(Test());
        //}

        //static int FeetToInches(int feet)
        //{
        //    int result = feet * 12;

        //    return result;
        //}

        //static string Test()
        //{
        //    bool x = false;
        //    if (x)
        //        return "muhehe";
        //    else
        //        return "hahaha";
        //}
    }

    class UnitConverter
    {
        int ratio;
        public UnitConverter(int unitRatio) { ratio = unitRatio; }
        public int Convert(int unit) { return unit * ratio; }
    }

    class Test
    {
        static void Main()
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToInchesConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));


            //Learning conversion
            // Checked key word stops overflow from happening
            // double numeric is default, coversion is instrinsic
            //Console.WriteLine();

            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);

        }
    }
}
