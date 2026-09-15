// 7.4 - Largest in Array

int[] largestArray = [0,3,5,8,1,2,7,3];

int largestNumber = 0;
foreach (int number in largestArray) {
    if (number > largestNumber) {
        largestNumber = number;
    }
}
Console.WriteLine(largestNumber);

//7.15 - Person

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

