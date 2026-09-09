Console.WriteLine("Hello world!");
Console.WriteLine(2 + 2);
Console.WriteLine("Hello" + " world!");

byte test = 255;
Console.WriteLine(test);

test++;
Console.WriteLine(test);


int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

float radius1 = 1^2;
float radius2 = 3^2;
float radius3 = 5^2;
double pie = 3.14;
double area1 = pie * radius1;
double area2 = pie * radius2;
double area3 = pie * radius3;

Console.WriteLine(area1);
Console.WriteLine(area2);
Console.WriteLine(area3);


double celsius = 25;

double fahrenheit = 32 + 9/5*celsius;

Console.WriteLine("The temperature " + celsius + " celsius is " + fahrenheit + " in fahrenheit");

double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9;

Console.WriteLine(monday - tuesday);
Console.WriteLine(tuesday - wednesday);
Console.WriteLine(wednesday - thursday);
Console.WriteLine(thursday - friday);
Console.WriteLine(friday - saturday);
Console.WriteLine(saturday - sunday);

/*
int unix = 1788958378;

int minutes = unix/60;
int hours = minutes/60;
int days = hours/24;

int years = days/365;

Console.WriteLine(years);
*/

const int secsPerDay = 24 * 60 * 60;
const int secsPerYear = 365 * secsPerDay;
long epoch = 1788958378;
long years = epoch / secsPerYear;
long days = (epoch - years * secsPerYear) / secsPerDay;
Console.WriteLine(epoch + " seconds -> " + years + " years and " + days + " days");


int i = 42;
long l = 56;
float f = 3.14159F;
double d = 3.14159 * 10;
Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.00}", i, l, f, d);

// test test