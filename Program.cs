/*Name: Andrew Wood
 *Date: 3/18/19
 *Purpose: FileI/O class that reads in a list of numbers and exports two text files of even and odd numbers
 * 
 * 
 */


using System;
using System.IO;
using static System.Console;

namespace FileI.OActivity
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence; //string variable for comparing input and output
            int i = 0;//integer to be used for cycling through data
            int[] holder = { 0 };//integer array in order to help with data reading and comparing

            FileStream fileNumbers = new FileStream("Numbers.txt", FileMode.OpenOrCreate);//file stream for opening the Numbers.txt file
            FileStream fileEven = new FileStream("Even.txt", FileMode.Create);//file stream for creating the Even.txt file
            FileStream fileOdd = new FileStream("Odd.txt", FileMode.Create);//file stream for creating the Odd.txt file

            StreamReader streamNumbers = new StreamReader(fileNumbers); //This is the stream reader for reading what information is obtained through the file stream fileNumbers, which is connected to the Numbers.txt file

            StreamWriter streamEven = new StreamWriter(fileEven);//This is the streamwriter object that will be used to write to the even text file, using the file stream fileEven
            StreamWriter streamOdd = new StreamWriter(fileOdd);//This is the streamwriter object that will be used to write to the odd text file, using the file stream fileOdd

           
            while ((sentence = streamNumbers.ReadLine()) != null) //while loop continues if the current line that is being read is not empty
            {
                holder[i] = Convert.ToInt32(sentence); //array that is converting whatever number is at that position of the array to an integer value from the string variable sentence

                    if (holder[i] % 2 == 0) //if statement using mod division to determine if the number is even/odd. If their is a remainder, it is odd. If there is not remainder, it is even
                        {
                            streamEven.WriteLine(holder[i]); //If the number is even, this streamwriter called streamEven writes the current value in the array to the Even text file using the fileEven file stream
                        }
                
                    else
                        {
                            streamOdd.WriteLine(holder[i]);//If the number is odd, this streamwriter called streamOdd writes the current value in the array to the Odd text file using the fileOdd file stream
                        }
            }

            streamEven.Close();//when the process is done, this stream writer is closed
            streamOdd.Close(); //when the process is done, this stream writer is closed
            streamNumbers.Close();//when the process is done, this stream reader is closed

            fileNumbers.Close();//when the process is done, this file stream is closed


            WriteLine("Files generated. Check project folder!"); //completed program
            ReadKey();//completed program



            //I will delete the text files that have been created when you run the program, that way it is a brand new program to show that it works!
        }
    }
}
