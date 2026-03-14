using ProblemSolving;
using static ProblemSolving.StringReverser;

//var inputNumber = Convert.ToString(Console.ReadLine());

////var answer = PrimeNumber.CheckPrimeNumber(inputNumber);
////Console.WriteLine(answer);

//var stringReverser = new StringReverser();
//var answer2 = stringReverser.Reverse(inputNumber);
//Console.WriteLine(answer2);

//var factorial = new Factorial();
//factorial.CalculateFactorial(5);
//Console.WriteLine(factorial.CalculateFactorial(5));

//var bananaPuzzleSolver = new BananaPuzzleSolver();

//var answer3 = bananaPuzzleSolver.Solve(3000, 1000, 1000, 1);
//Console.WriteLine(answer3);

//var makeThreeStringsEqual = new MakeThreeStringsEqual();
//var answer = makeThreeStringsEqual.FindMinimumOperations("abb", "abc", "ab");
//Console.WriteLine(answer);

var removeDub = new RemoveDuplicatesfromSortedArray();
int[] array = { 0 ,1, 2, 2, 2, 3, 3, 4, 4};
var answer = removeDub.RemoveDuplicates(array);
Console.WriteLine(answer);