using LeetCode;
using System;
using System.Reflection.Metadata;

//Time Complexity

//O(1) - Constant
//O(n) - Linear
//O(n^2) - Quadratic
//O(log n) - Logarithmic

//int n = 100;
//for (int i = 1; i < n; i++) { };

//n = 1;//O(1) - Constant

//for (int i = 1; i < n; i++) { };//O(n) - Linear

//for(int i = 1; i < n; i++)
//{
//    for (int j = 1; j < n; j++) { };//O(n^2) - Quadratic
//}

//{ 1, 2, 3, 4, 5 , 6}.BinarySearch(3);//O(log n) - divide by half - Logarithmic

//FizzBuzz obj = new FizzBuzz();
//obj.FizzBuzzProgram();

//ReverseString obj = new ReverseString();
//obj.ReverseStringProgram();

//PalindromeString obj = new PalindromeString();
//obj.PalindromeStringProgram();

//PalindromeNumber obj = new PalindromeNumber();
//obj.PalindromeNumerProgram(121);

//FactorialNumber obj = new FactorialNumber();
//obj.FactorialNumberProgram(1);

//FibonacciSeries obj = new FibonacciSeries();
//obj.FibonacciSeriesprogram(7);

//PrimeNumber obj = new PrimeNumber();
//Console.WriteLine(obj.PrimeNumberProgam(4));

//ArmstrongNumber obj = new ArmstrongNumber();
//obj.ArmstrongNumberProgram(22);

//SwapNumbers obj = new SwapNumbers();
//obj.Swapnumbersprogram(10, 20);

//LargestNumber obj =  new LargestNumber();
//obj.LargestNumberProgram();

//SmallestNumber obj = new SmallestNumber();
//obj.SmallestNumberProgram();

//SecondLargest obj = new SecondLargest();
//obj.SecondLargestProgram();

//SecondSmallest obj = new SecondSmallest();
//obj.SecondSmallestProgram();

//RemoveDuplicates obj = new RemoveDuplicates();
//obj.RemoveDuplicatesProgram();

//CountDuplicate obj = new CountDuplicate();
//obj.CountDuplicateProgram();

//FindMissingElement obj = new FindMissingElement();
//obj.FindMissingElementprogram();

//MaxOccChar obj = new MaxOccChar();
//obj.MaxOccCharProgram();

//CountVowels obj = new CountVowels();
//obj.CountVowelsProgram();

//CountWords obj = new CountWords();
//obj.CountWordsProgram();

//ReverseSentense obj = new ReverseSentense();
//obj.ReverseSentenceProgram();

//StringAnagram obj = new StringAnagram();
//obj.StringAnagramProgram();

//BubbleSort obj = new BubbleSort();
//obj.BubbleSortProgram();

//SelectionSort obj = new SelectionSort();
//obj.SelectionSortProgram();

//InsertionSort obj = new InsertionSort();
//obj.InsertionSortProgram();

//BinarySearch obj = new BinarySearch();
//obj.BinarySearchProgram();

//LinearSearch obj = new LinearSearch();
//obj.LinearSearchProgram();

//MergeTwoArrays obj = new MergeTwoArrays();
//obj.MergeTwoArraysProgram();

//IntersectionOfTwoArray obj = new IntersectionOfTwoArray();
//obj.IntersectionofTwoArrayProgram();

//UnionOfTwoArray obj = new UnionOfTwoArray();
//obj.UnionOfTwoArrayProgram();

//RotateArrayLeft obj = new RotateArrayLeft();
//obj.RotateArrayLeftProgram();

//RotateArrayRight obj = new RotateArrayRight();
//obj.RotateArrayRightProgram();

//MoveZeroToTheEnd obj = new MoveZeroToTheEnd();
//obj.MoveZeroToTheEndProgram();

//SumOfDigits obj = new SumOfDigits();
//obj.SumOfDigitsProgram();

//ReverseNumber obj = new ReverseNumber();
//obj.ReverseNumberProgram();

//PerfectNumber obj = new PerfectNumber();
//obj.PerfectNumberProgram();

//GCDOfNumber obj = new GCDOfNumber();
//obj.GCDOfNumberProgram();

//LCMOfNumbers obj = new LCMOfNumbers();
//obj.LCMOfNumbersProgram();

//CheckLeapYear obj = new CheckLeapYear();
//obj.CheckLeapYearProgram();


//------------------------------------------------------------------------------------------
//Node first = new Node(10);
//Node second = new Node(20);
//Node third = new Node(30);

//first.Next = second;
//second.Next = third;

//Node curr = first;

//while(curr != null)
//{
//    Console.Write(curr.Data + "->");
//    curr = curr.Next;
//}
//Console.WriteLine("Null");


//-------------------------------------------------------------------------------------
//Node first = new Node(10);
//Node second = new Node(20);
//Node third = new Node(30);
//Node fourth = new Node(40);

//first.Next = second;

//second.Prev = first;
//second.Next = third;

//third.Prev = second;
//third.Next = fourth;

//fourth.Prev = third;

//Node curr = first;

//while(curr != null)
//{
//    Console.Write(curr.Data + "->");
//    curr = curr.Next;
//}
//Console.WriteLine("Null");


//-----------------------------------------------------------------------------------------
//ReverseLinkedList obj = new ReverseLinkedList();
//obj.Add(10);
//obj.Add(20);
//obj.Add(30);
//obj.Add(40);

//obj.Display();

//Console.WriteLine("Reverse the LinkedList");

//obj.Reverse();
//obj.Display();


//----------------------------------------------------------------------------------------
//MergeLinkedList obj = new MergeLinkedList();

//NodeList list1 = new NodeList(1);
//list1.Next = new NodeList(3);
//list1.Next.Next = new NodeList(5);
//obj.Display(list1);

//NodeList list2 = new NodeList(2);
//list2.Next = new NodeList(4);
//list2.Next.Next = new NodeList(6);
//obj.Display(list2);

//NodeList MergedList = obj.Merge(list1, list2);
//obj.Display(MergedList);

//----------------------------------------------------------------------------
//CreateStack obj = new CreateStack(5);
//obj.push(10);
//obj.push(20);
//obj.push(30);
//obj.push(40);

//obj.display();

//Console.WriteLine("The top element is " + obj.peek());

//obj.pop();
//Console.WriteLine("The stack after popping the element is ");
//obj.display();

//obj.push(50);
//Console.WriteLine("The stack after pushing an element is ");
//obj.display();

//-----------------------------------------------------------------------------------------
//QueueCreate obj = new QueueCreate(5);
//obj.enqueue(10);
//obj.enqueue(20);
//obj.enqueue(30);
//obj.enqueue(40);
//obj.enqueue(50);

//obj.display();
//Console.WriteLine("---------------------------------------");
//obj.dequeue();
//obj.peek();
//-----------------------------------------------------------------------------------

//CountChar obj = new CountChar();
//obj.CountCharProgram();

//FrequencyOfElementInArray obj = new FrequencyOfElementInArray();
//obj.FrequencyOfElementInArrayProgram();

//Find1stNonRepeatingChar obj = new Find1stNonRepeatingChar();
//obj.Find1stNonRepeatingCharProgram();

//MatrixAddition obj = new MatrixAddition();
//obj.MatrixAdditionProgram();

MatrixMultiplication obj = new MatrixMultiplication();
obj.MatrixMultiplicationProgram();

