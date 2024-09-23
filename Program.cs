// See https://aka.ms/new-console-template for more information

namespace RotateListRight1
{
    public class RotateListRight
    {
        // Method 
        public List<int> RotateListRight1(List<int> data, int amount) //step 1 funtion
        {
            int splitPoint = data.Count - amount; //step 2 calculate the split point

            //split list step 3
            List<int> slice1 = data.GetRange(splitPoint, amount); //From splitPoint to end
            List<int> slice2 = data.GetRange(0, -1); // From start to splitPoint - 1

            slice1.AddRange(slice2);

            return slice1;
        }
    }

    public class Program
    {
        public static void Main()
        {
            RotateListRight rotateListRight = new RotateListRight();

            List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> rotatedList = rotateListRight.RotateListRight1(data, 5);
            
            //concatenar join both list 
            Console.WriteLine(string.Join(" ", rotatedList));
        }
             //I CANT SEE THE RESULT :(
    }

}