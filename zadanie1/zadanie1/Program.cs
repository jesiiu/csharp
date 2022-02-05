using System.Collections.Generic;


Console.Write("Insert your EAN-13: ");


string UserEAN = Console.ReadLine();
char[] ean = UserEAN.ToCharArray();
int[] eanValue = Array.ConvertAll(ean, c => (int)Char.GetNumericValue(c));

if(UserEAN.Length == 13)
{ 
int sum()
{
    int suma = 1 * eanValue[0] + 3 * eanValue[1] + 1 * eanValue[2] + 3 * eanValue[3] + 1 * eanValue[4] + 3 * eanValue[5] + 1 * eanValue[6] + 3 * eanValue[7] + 1 * eanValue[8] + 3 * eanValue[9] + 1 * eanValue[10] + 3 * eanValue[11];
    
    if (suma % 10 == 0)
    {
        return suma-suma;
    }
    else
    {
        return (10 * ((suma + 9) / 10))-suma;
    }
    
}

    int suma = sum();
    Console.WriteLine($"EAN check value: {suma} is valid");
}
else
{
    Console.WriteLine("Invalid EAN");
}


 
   








