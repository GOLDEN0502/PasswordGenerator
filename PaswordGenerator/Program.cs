Random random = new Random();
int intPasword = random.Next();
int intPasword2 = random.Next(1,2);
char[] letters = new char[9];
for (int i = 0;i < 9 ; i++)
{
    letters[i] = (char)('A' + random.Next(26)); // Заполняем массив


}
if (intPasword2 == 1)
{
    Console.WriteLine("Сгенерированный пароль: " + new string(letters) + intPasword);
}
if (intPasword2 == 2)
{
    Console.WriteLine("Сгенерированный пароль: " + intPasword + new string(letters));
}
