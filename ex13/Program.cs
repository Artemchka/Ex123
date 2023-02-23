// Дан текст. В тексте нужно все пробелы заменить черточками,  маленькие буквы к большими К. а большие С заменить маленькими с

string am = "Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали вместо нашего милого Винценгороде, вы бы взяли приступом согласие прусского короля.";

string Replace(string am, char oldValue, char newValue)
{
   string result = String.Empty;
 int length = am.Length;

 for (int i =0; i < length; i++)
 {
    if(am[i] == oldValue) result = result +$"{newValue}";
    else result = result + $"{am[i]}";
    
 }
    return result;
}

string newAm = Replace(am, ' ', '|');
Console.WriteLine(newAm);
Console.WriteLine();
newAm = Replace(newAm, 'а', 'А');
Console.WriteLine(newAm);
