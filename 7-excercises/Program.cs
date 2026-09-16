// 7.4 - Largest in Array

int[] largestArray = [0,8,5,8,1,2,7,3];

int largestNumber = 0;
foreach (int number in largestArray) {
    if (number > largestNumber) {
        largestNumber = number;
    }
}

for (int i=0; i<largestArray.Length; i++) {
    int value = largestArray[i];
    if (value == largestNumber) {
        Console.WriteLine(i);
    }
}
Console.WriteLine("largest number is: "+largestNumber);

//7.15 - Person
/*
Person person = new Person { 
    age = 24, 
    name = "Henrik Hansen", 
    weight = 65, 
    height = 178 
};

Console.WriteLine("Name is: "+person.name + " Age is: "+person.age + " Weight is: "+person.weight + " Height is: "+person.height);

class Person {
    public string? name;
    public int age;
    public int weight;
    public int height;
}
*/
// 7.3 - Array Type
// By the x[] before the array is initalized

// 7.5 - Size of array allocation
// By putting a number into the [] when intializing the array


// 7.7 - Sudoku Puzzle -
// I would probably a 2 dimensional array. Make that a 9x9.
// 

int[,] marray = {
    {1,2,3,4},
    {2,3,4,5},
    {3,4,5,6}
};
for (int y=0 ; y<marray.GetLength(0) ; y++) {
    for (int x=0 ; x<marray.GetLength(1) ; x++)
        Console.Write(marray[y,x]+" ");
    Console.WriteLine("");
}

// 7.12 - Calendar

int[] daysMonth = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] daysLeap = [31,29,31,30,31,30,31,31,30,31,30,31];

for (int i=2000; i <=2020; i++) {
    bool leap = (i%4==0);
    int[] month = leap ? daysLeap : daysMonth;

    Console.Write(i+" :[ ");
    foreach (int length in month) {
        Console.Write(length + " ");
    }
    Console.WriteLine("]");
}

//7.16 - Direction
/*
enum Direction {
    North,
    East,
    West,
    South
}
*/
//7.14 - Suduko Checker

int [,] sudoku = {
    {5,3,4,6,7,8,9,1,2},
    {6,7,2,1,9,5,3,4,8},
    {1,9,8,3,4,2,5,6,7},
    {8,5,9,7,6,1,4,2,3},
    {4,2,6,8,5,3,7,9,1},
    {7,1,3,9,2,4,8,5,6},
    {9,6,1,5,3,7,2,8,4},
    {2,8,7,4,1,9,6,3,5},
    {3,4,5,2,8,6,1,7,9},
};

bool[] check; 
check = new bool[9];

for (int y = 0; y < sudoku.GetLength(0); y++) {
    for (int x = 0; x < sudoku.GetLength(1); x++) {
        int value = sudoku[x,y];
        if (check[value-1]== true) {
            Console.WriteLine("Problem with: "+x+","+y);
        }
        check[value-1]=true;
    }
    for (int x = 0; x < sudoku.GetLength(1); x++) {
        check[x]=false;
    }
}

for (int x = 0; x < sudoku.GetLength(0); x++) {
    for (int y = 0; y < sudoku.GetLength(1); y++) {
        int value = sudoku[x,y];
        if (check[value-1]== true) {
            Console.WriteLine("Problem with: "+x+","+y);
        }
        check[value-1]=true;
    }
    for (int y = 0; y < sudoku.GetLength(1); y++) {
        check[y]=false;
    }
}

// 7.8 Areas of Circles

int[] radius = {1, 3, 5};
double pi = 3.14;
foreach (int radi in radius) {
    double area = pi*(radi*radi);
    Console.WriteLine("With a radius of: "+radi+" the area is: "+area);
}