// C# program to print Hello World! 
using System; 

// namespace declaration 
namespace HelloWorldApp { 
    
    // Class declaration 
    class Geeks { 
        
        // Main Method 
        static void Main(string[] args) { 
            
            // statement 
            // printing Hello World! 
            Console.WriteLine("Hello World! This is me!"); 

            for(int i=0, i < 10, i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }    
            
            // To prevents the screen from 
            // running and closing quickly 
            Console.ReadKey(); 
        } 
    } 
} 
