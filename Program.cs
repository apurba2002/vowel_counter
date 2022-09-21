while (true)
{
    Console.WriteLine("Enter a word :-");
    string word = Console.ReadLine().ToLower();
    int count = 0;


    for (int i = 0; i < (word.Length); i++)
    {
        char test_char = word[i];
        if ( word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
            {
        
                count++;
            }
    }
    Console.WriteLine("Number of vowel in this word is :"+count);

}