// 5.12 - Incrementing a month
/*
int month;
month = 2;

Console.WriteLine(month);
*/
//5.19 - Decision of Purchase

double price = 599.95; // Price of item
double budget = 1000.0; // Your budget
bool requiredReading = true; // If we are in the need of reading this is true
bool shouldBuy = price < budget && requiredReading; // This checks if it fits our budget and we need to read. If it does shouldBuy is true.

//5.21 - Manual Inference

//6.1 - Epoch

//7.6 - Multiplication Table

int size = 25;
int[] timesTable;
timesTable = new int[size];

for (int i = 0; i < size; i++) {
    timesTable[i] = 3*i;
    Console.Write(timesTable[i]+", ");
}
Console.WriteLine("");
// to reduce number of observations i would probably look at index 4,9,19 where we can easily know what the value should be.

//7.13 - Calendar Prettyprinting
/*
string[] days = {
    "monday",
    "tuesday",
    "wednesday",
    "thursday",
    "friday",
    "saturday",
    "sunday"
};

string[] month = {
    "january",
    "february",
    "march",
    "april",
    "may",
    "june",
    "july",
    "august",
    "september",
    "october",
    "november",
    "december",
};

int[] daysMonth = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] daysLeap = [31,29,31,30,31,30,31,31,30,31,30,31];

int year = 2019;

bool leap = (i%4==0);
int[] monthLength = leap ? daysLeap : daysMonth;
*/

// 7.17 Units

int meters = 5;

string[] units = {"cm", "mm", "inches",};
int[] conversion = {100, 1000, 39,};

int newUnit;
for(int i = 0; i<units.Length; i++) {
    newUnit = meters * conversion[i];
    Console.WriteLine(newUnit+" "+units[i]);
}
