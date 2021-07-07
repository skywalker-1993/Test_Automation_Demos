namespace dotnet_tests
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Student(int age, string name)
        {
            Age = age; 
            Name = name; 
        }
        
        public static int addTwoNumbers(int a, int b){
            return a + b;
        }
    }

}