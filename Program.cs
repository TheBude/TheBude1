Console.WriteLine("Assolumu allaykum! Men yoshni o'rtasidagi taffavutni hioblaydigan dasturman");
Console.Write("Iltimos menga uzingiz haqida ma'lumot bering \nismingiz: ");
string name = Console.ReadLine();

Console.Write($"{name} yoshingiz: ");
string age  = Console.ReadLine();
int copyAge = Convert.ToInt32(age);

Console.Write("siz solishtrmoqchi bulgan odamning ismi: ");
string name2 = Console.ReadLine();

Console.WriteLine($"{name2} ning yoshi: ");
string age2 = Console.ReadLine();
int copyAge2 = Convert.ToInt32(age2);

Console.WriteLine($"Aha {name} siz bilan {name2} ning orasidagi yosh farqi {copyAge - copyAge2} ga teng ekan !!!");
