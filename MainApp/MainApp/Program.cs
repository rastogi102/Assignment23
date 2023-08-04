using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManagementModule userManagement = new UserManagementModule();
            userManagement.RegisterUser("Nikhil Rastogi ", "nikhil@example.com");

            FileProcessingModule fileProcessing = new FileProcessingModule();
            fileProcessing.ProcessFile("data.txt");

            DataVisualizationModule dataVisualization = new DataVisualizationModule();
            dataVisualization.ShowData();

            Console.ReadKey();
        }
    }
    public class UserManagementModule
    {
        public void RegisterUser(string username, string email)
        {
            if (DataValidator.IsValidEmail(email))
            {
                // Implement user registration logic
                Console.WriteLine($"User {username} registered successfully with email: {email}");
            }
            else
            {
                Console.WriteLine($"Invalid email: {email}. Please provide a valid email address.");
            }
        }
    }

    public class FileProcessingModule
    {
        public void ProcessFile(string filename)
        {
            // Implement file processing logic as needed
            Console.WriteLine($"Processing file: {filename}");
        }
    }

    public class DataVisualizationModule
    {
        public void ShowData()
        {
            // Implement data visualization logic as needed
            Console.WriteLine("Displaying data...");
        }
    }
}
