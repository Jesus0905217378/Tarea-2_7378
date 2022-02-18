byte num1, num2;
ushort multip;
Console.WriteLine("Ingrese dos numeros de dos cifras ");
num1= Convert.ToByte(Console.ReadLine());
num2= Convert.ToByte(Console.ReadLine());
multip = Convert.ToUInt16(num1 * num2);

Console.WriteLine("\nla multiplicacion de los numeros es: " + multip);