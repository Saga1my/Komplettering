
string input = string.Empty; //här är stringen input tom


while(input!="hejdå"){ //detta är så att programmet stängs ner när man skriver "hejdå"

    Console.WriteLine("Hur gammal är du?"); //detta är så att användaren ska förstå vad de förväntas göra
    Console.WriteLine("Skriv ''hejdå'' för att avsluta programmet "); //och detta är så det förstår hur de stänger ner programmet

    input = Console.ReadLine(); //input ändras till det som användaren skriver

    if(!int.TryParse (input, out int age)){ //i denna if sats kollar jag om det användaren skrivit faktist är en siffra
        if(age>=30&&age<=122){
        Console.WriteLine("DU ÄR GAMMAL");} //om användaren skriver att hen är äldre än 30 men yngre än 122 år säger programmet att hem är gammal
        else if(age<=30&&age>0){
        Console.WriteLine("Du är bra ålder");}//om användaren skriver att hen är under 30 men över 0 är den bra ålder
        else if(age>122){
        Console.WriteLine("DU LJUGER VÄRLDENS ÄLSTA PERSON ÄR 122 ÅR >:(");} //om användaren skriver att den är 122+ ljuger hen
        else if(age<=0){
        Console.WriteLine("Så du skriver från din mammas mage? LÖGNARE");} //om användaren säger att hen är <0 ljuger hen

    }
    else {Console.WriteLine($"{input} är inte ens en siffra? försök igen");}; //det här händer om användaren ej skriver en siffra


}
Console.ReadLine(); //detta gör så att koden skrivs ut

