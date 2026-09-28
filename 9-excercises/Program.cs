// 9.1 - Indexing

int iterationer = 10; // too many iterations for size of array
int[] array = {1, 2, 3, 4, 5};
// increment
for (int i=0 ; i<iterationer ; i++) {
    try {
        array[i]++;
    } catch(IndexOutOfRangeException) {
        Console.WriteLine("Caught IndexOutOfRangeException");
    }
}
// print
for (int i=0 ; i<array.Length ; i++) {
    Console.WriteLine(array[i]);
}

// 9.2 - Accounts
/*
int[] accounts = {903, 716, 67};

int GetAccountNumber ()
{
    Console.WriteLine("Enter an account number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId)
{
    Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
    
while (true) {
    try {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    } catch (IndexOutOfRangeException) {
        Console.WriteLine("This account does not exist");
    } catch (FormatException) {
        Console.WriteLine("The account has to be a number");
    }
}
*/
// 9.3 - Average Grade 

int[] grades = {4,7,02,00,10,4,12};

int GetGrade (int courseid) {
    int grade;
    grade = grades[courseid];
    if (grade >= 02) {
        return grade;
    } else {
        throw new Exception();
    }
}

int count = 0;
int sum = 0;

for(int courseid = 0; courseid < grades.Length; courseid++) {
    try {
        sum += GetGrade(courseid);
        count++;
    } catch (Exception) {
    }
}

Console.WriteLine("Average grade is " + ((double)sum / count));