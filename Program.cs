using FindMaximumNumber;

Console.WriteLine("Find the Maximum Number : ");
int output = MaximumNumberCheck.MaximumNumber(25, 15, 13);
Console.WriteLine(output);
double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(52.26, 18.92, 15.12);
Console.WriteLine(doubleoutput);
string strigoutput = MaximumNumberCheck.MaximumStringNumber("linklist", "shellscript", "visualstudio");
Console.WriteLine(strigoutput);
int[] intArray = { 102, 152, 165, 205, 209, 215 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 2.63, 25.36, 52.09, 12.32, 46.15 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "araqu", "meedaram", "beach", "agra", "ooti" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();
Console.ReadKey();