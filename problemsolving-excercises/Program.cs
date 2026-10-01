// 8.7 - Discriminants and Roots
int disc (int a, int b, int c){
    return ((b*b)-4*a*c);
}

int discChecker(double value) {
    if (value < 0) {
        return -1;
    } else if (value == 0) {
        return 0;
    } else {
        return 1;
    }
}

double[] roots (int a, int b, int c) {
    double d = disc(a, b, c);
    int rootCount = discChecker(d);

    if (rootCount == -1) {
        double[] roots1 = new double[0];
        return roots1;
    } else if (rootCount == 0) {
        double[] roots2 = new double[1];
        roots2[0] = (-b) / (2*a);
        return roots2;
    } else {
        double[] roots3 = new double[2];
        roots3[0] = (-b - Math.Sqrt(disc(a, b, c)))/ (2*a);
        roots3[1] = (-b + Math.Sqrt(disc(a, b, c)))/ (2*a);
        return roots3;
    }
}

double[] ans = roots(1, -4, 4);

foreach(double root in ans) {
    Console.WriteLine(Math.Round(root,2));
}

//7.13 - Calendar Prettyprinting

string[] days = {
    "mon",
    "tue",
    "wed",
    "thu",
    "fri",
    "sat",
    "sun"
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

int firstDay = 0;
int remainder = 0;

// Print the month
for (int i = 0; i<month.Length; i++) {
    Console.WriteLine(month[i]);

    //Print the weekdays
    for (int j = 0; j<days.Length; j++) {
        Console.Write(" "+days[j]);
    }
    Console.WriteLine("");
    
    for (int h = 0; h < firstDay; h++) {
        Console.Write(string.Format("{0,4}"," "));
    }
    //Print the day number
    for (int k = 1; k<=daysMonth[i]; k++) {
        Console.Write(string.Format("{0,4}",k));
        if (k%7==0+remainder) {
            Console.WriteLine("");
        }
    }
    
    Console.WriteLine("");
    Console.WriteLine("");
    remainder = 7-((daysMonth[i]+firstDay)%7);
    firstDay = 7-remainder;
    if (remainder == 7) {remainder = 0;}
}