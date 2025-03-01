namespace helloworld
{
    class Hello
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            LoopEx(age);
        }
        static void LoopEx(int number){
            for(int i = 1; i < 10; i++){
                number += 10;
                if(i == 1) {
                    Console.Write("In " + i + " decade. You will be: " + number + "\n");
                }
                else {
                    Console.Write("In " + i + " decades. You will be: " + number + "\n");
                }
            }
        }
    }

}