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


