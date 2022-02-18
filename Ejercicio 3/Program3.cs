long num1, num2, suma, resta, producto;
Console.WriteLine("Ingrese dos numeros enteros largos ");
num1 = Convert.ToInt64(Console.ReadLine());
num2 = Convert.ToInt64(Console.ReadLine());

suma = num1 + num2;
resta= num1 - num2;
producto = num1 * num2;

Console.WriteLine("\nLa suma es: " + suma);
Console.WriteLine("\nLa resta es: " + resta);
Console.WriteLine("\nEl producto es: " + producto);