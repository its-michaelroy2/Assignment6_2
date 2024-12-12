namespace Assignment6_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment6.2.1");
            Console.WriteLine("===============\n");

            MockStack stack = new MockStack(5); //Set mock stack size of 5

            //Push/Pop numbers. If more than allocated size or too many removed, will display error msg
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());

            stack.Push(4);

            //Try to pop more elements than we pushed
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("\nAssignment6.2.2");
            Console.WriteLine("===============\n");
            int[] arr = { 1, 2, 3, 4 };
            int[] arr2 = { -1, 1, 0, -3, 3 };

            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            MultiplyAllExceptSelf(arr);

            Console.WriteLine("\nOriginal Array: " + string.Join(", ", arr2));
            MultiplyAllExceptSelf(arr2);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        //Multiply all elements except the crrent index
        public static void MultiplyAllExceptSelf(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        product *= arr[j];
                    }
                }
                result[i] = product;
            }
            Console.WriteLine("Output: " + string.Join(", ", result));
        }

    }

    public class MockStack
    {
        private int[] arr; //Storage array
        private int top; //Imdex of top
        private int capacity; //Max cap of stack

        //Constructor inits stack with our given size
        public MockStack(int size)
        {
            arr = new int[size];
            capacity = size;
            top = -1;
        }

        //Push method
        public void Push(int value)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow! " + value);
                return;
            }

            Console.WriteLine("Push: " + value);
            arr[++top] = value;
        }

        //Remove and return top element
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Cannot use pop for an empty stack!");
                return -1;
            }

            //If not empty return top el and decrement top
            return arr[top--];
        }


    }

}