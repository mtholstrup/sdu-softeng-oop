// 8.3 - Sudoku Prettyprinter

int[][] puzzle = {
    new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
    new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
    new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
    new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
    new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
    new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
    new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
    new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
    new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
};

void printer (int[][] puzzle) {
    for (int i = 0; i<9; i++) {
        if (i%3==0) {
            Console.WriteLine("+-----+-----+-----+");
        }
        for (int x = 0; x<9; x++) {
            Console.Write((x%3 == 0 ? "|" : " ")+puzzle[i][x]);
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("+-----+-----+-----+");
}

printer(puzzle);

//8.4 - Sum
int adder (int x, int y) {
    return x+y;
}

Console.WriteLine(adder(3, 4));
Console.WriteLine(adder(5, 4));


// 7.9 - Daily Differences

double[] daysTemp = {21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9};

for(int i = 0; i<daysTemp.Length-1; i++) {
    double diff;
    diff = Math.Round(daysTemp[i] - daysTemp[i+1], 3);
    Console.Write(diff+", ");
}
Console.WriteLine("");

// 8.8 - Factorial Function

int fac(int n) {
    if (n == 0) {
        return 1;
    } else {
        return n * fac(n-1)!;
    }
}

for (int i = 0; i<=5; i++) {
    Console.Write(fac(i)+", ");
}
Console.WriteLine("");

// 8.9 - Properties of circles 
double pi = 3.14;
double areaCircle(int r) {
    int rSquared = r*r;
    return pi * rSquared;
}

for (int i = 1; i<=5; i+=2) {
    Console.Write("When radius is: "+i+". Area is: "+areaCircle(i));
    Console.WriteLine("");
}

// 8.5 - Own Square Root

double sqrt(double n) {
    double candidate = 0.0;
    
    for (double pointer = 1000000000.0; pointer>=0.000000001; pointer/=10) {
        candidate += 10*pointer;
        for (int i = 0; i < 10; i++) {
            candidate -= pointer;
            if (candidate * candidate < n) {
                break;
            }
        }
    }
    return candidate;
}

Console.WriteLine(sqrt(7));