# Porównanie szybkości StringBuildera 

Napisz program, który porówna szybkość wykonywania operacji łączenia tekstu pomiędzy operatorem dodawania (''+'') i klasą ''StringBuilder()''.

W tym celu zbuduj napis składającyc się w wielu powtórzeń (np. 10 tysiecy) napisu ''"Witaj Świecie"'' i wyznacz czas wykoanania algorytmu dla obu porównywanych metod. 
Do wyznaczenia casu wykonania programu można wykorzystać własność [System.DateTime.Now](https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-6.0), która zwraca aktualny czas z dokładnością do milisekund. Ta wartość może zostać wywołana do pomiaru czasu przed i po wykonaniu algorytmu. Przedział czasu między dwoma pomiarami czasu jest strukturą typu typu [TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0). Struktura ta udostepnia własność [TimeSpan.TotalMilliseconds](https://learn.microsoft.com/en-us/dotnet/api/system.timespan.totalmilliseconds?view=net-6.0) zwracającą całkowitą liczbę milisekund pomiedzy pomiarami czasu. 


