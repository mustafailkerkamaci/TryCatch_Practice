using System.Net.Http.Headers;

Console.WriteLine("Sayi gir : ");


bool program = false;

while(!program)
{
    try
    {
        string input = Console.ReadLine();

        int number = Convert.ToInt32(input);
        int sqr = number * number;

        Console.WriteLine($"Girdigin sayinin karesi :{sqr}");
        program = true; // programi sonlandiracak olan degiskeni true yapar ve donguden cikilir.

    }
    catch (FormatException)// try blogunda bicim hatasi olursa bu blok calisacak. 
    {
        Console.WriteLine("Gecersiz giris! Sayi Gir!!");


    }
    catch (OverflowException)// try blogunda sayi sinirlarinin disina cikarsa bu blok calisacak.
    {
        Console.WriteLine("Gecersiz giris! Sayi cok buyuk ya da cok kucuk!!");
    }
    catch (Exception ex) // try blogunda hicbir hata yakalanmazsa bu blok calisacak.
    {
        Console.WriteLine($"Bilinmeyen bir hata olustu: {ex.Message}");
    }
    
}
Console.WriteLine("Program Sonlandi");
