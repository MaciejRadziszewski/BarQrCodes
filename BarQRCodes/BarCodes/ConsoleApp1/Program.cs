
int main()
{
    int liczba = -5551;
    bool ujemna = false;
    if (liczba < 0)
    {
        ujemna = true;
        liczba = -liczba;
    }
    int cyfra = 5;
    int tysiace = liczba / 1000;
    int setki = liczba / 100 - liczba/1000 * 10;
    int dziesiatki = liczba / 10 - liczba/100 * 10;
    int jednosci = liczba % 10;
   
    
    if (ujemna == false)
    {
        if(cyfra > tysiace && tysiace != 0)
        {
            tysiace = cyfra;
        }
        else if(cyfra > setki && setki != 0)
        {
            setki = cyfra;
        }
        else if(cyfra > dziesiatki && dziesiatki != 0)
        {
            dziesiatki = cyfra;
        }
        else
        {
            jednosci = cyfra;
        }
    }
    else
    {
        if (cyfra < tysiace && tysiace != 0)
        {
            tysiace = cyfra;
        }
        else if (cyfra < setki && setki != 0)
        {
            setki = cyfra;
        }
        else if (cyfra < dziesiatki && dziesiatki != 0)
        {
            dziesiatki = cyfra;
        }
        else
        {
            jednosci = cyfra;
        }
    }
    int wynik = tysiace * 1000 + setki * 100 + dziesiatki * 10 + jednosci;
    if(ujemna == true)
    {
        wynik = -wynik;
    }
    Console.WriteLine(wynik);

    return 0;
    int n = 5;
    int[] lista = {1,3,4,2,5};
    Tuple<int, int>[] tuples;
    for (int i = 0; i < n; i++)
    {
        tuples[i] = new Tuple<int, int>(lista[i], i);
    }

}
main();
