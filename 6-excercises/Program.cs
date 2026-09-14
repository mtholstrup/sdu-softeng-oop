// 6.6 Celsius to Fahrenheit

for (double i=-5; i <= 40; i += 0.5) {
    
    double tF = 32 + 9/5*i;
    Console.WriteLine("Fahrenheit: "+tF+" Celsius: "+i);
}


// 6.3 Christmas Sale

int seconds_into_year = 30758520;
double price = 599.95;

int seconds_per_day = 60*60*24;
int days_for_christmas = 360 - 4;
int seconds_for_christmas = days_for_christmas * seconds_per_day;

Console.WriteLine(seconds_for_christmas);

double priceChristmas = Math.Round(price - price * .30, 2);

Console.WriteLine("Rebate price: "+priceChristmas); 

if (seconds_into_year > seconds_for_christmas && seconds_into_year < seconds_for_christmas+seconds_per_day) {
    Console.WriteLine("It's Christmas! Price is now 30% off: "+priceChristmas); 
} else {
    Console.WriteLine("It's not Christmas. Your price is: "+price);    
}

//5.20 - Dice

int dice = 1;
bool niceThrow;

if (dice > 3 && dice%2==0) {
    niceThrow = true;
} else {
    niceThrow = false;
}

Console.WriteLine(niceThrow);

//6.5 - Holidays

int month = 12;

if (month == 4) {
    Console.WriteLine("It is Spring Holiday. Enjoy!");
} else if (month == 7 || month == 8) {
    Console.WriteLine("It is Summer Holiday. Enjoy!");
} else if (month == 10) {
    Console.WriteLine("It is Autumn Holiday. Enjoy!");
} else if (month == 12) {
    Console.WriteLine("It is Christmas. Enjoy!");
} else {
    Console.WriteLine("Hard Work");
}

//6.9 - Areas of Circles
double pi = 3.14;
for (int i=1; i<=5; i+=2) {
    int iSquared = i*i;
    Console.WriteLine(pi*iSquared);
}

//6.4 - Length of month
int inputMonth = 4;

if (inputMonth == 1 || inputMonth == 3 || inputMonth == 5 || inputMonth == 7 || inputMonth == 8 || inputMonth == 10 || inputMonth == 12) {
    Console.WriteLine("The month has 31 days");
} else if (inputMonth%2 == 0 && inputMonth < 7 && inputMonth != 2 || inputMonth%2 == 1 && inputMonth > 7) {
    Console.WriteLine("The month has 30 days");
} else {
    Console.WriteLine("This month has 28 days");
}

//6.10 - Primes
bool isPrime = true;
for (int i=2; i<=100; i++) {
    for (int x=2; x < i; x++) {
        if (i%x==0) {
            isPrime = false;
        }
    }
    if (isPrime == true) {
        Console.WriteLine(i);
    }
}