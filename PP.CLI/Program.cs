using System;
using System.Xml.Linq;
using PP.Library.Models;
using PP.Library.Services;


namespace Practice // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var enrollments = new List<Client>();
            var allProjects = new List<Project>();

            ClientMenu(enrollments);
            ProjectMenu(allProjects, enrollments);



        }

        static void ClientMenu(List<Client> enrollments)
        {
            while (true)
            {
                Console.WriteLine("C. Create a Client");
                Console.WriteLine("R. List Clients");
                Console.WriteLine("U. Update a Client");
                Console.WriteLine("D. Delete a Client");
                Console.WriteLine("Q. Quit");

                var choice = Console.ReadLine() ?? string.Empty;

                if (choice.Equals("C", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("ID: ");
                    //in future id will be automated
                    var Id = int.Parse(Console.ReadLine() ?? "0");

                    //asks for name 
                    Console.WriteLine("Name: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Notes: ");
                    var notes = Console.ReadLine();

                    enrollments.Add(new Client
                    {
                        Id = Id,
                        Name = name ?? "John/Jane Doe",
                        Notes = notes ?? "n/a",
                        OpenDate = DateTime.Now,
                        ClosedDate = null,
                        IsActive = true
                    }
                    );



                }
                else if (choice.Equals("R", StringComparison.InvariantCultureIgnoreCase))
                {

                    //scary really  short way to list clients 
                    enrollments.ForEach(Console.WriteLine);
                }
                else if (choice.Equals("U", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Which client would you like to update? ");
                    enrollments.ForEach(Console.WriteLine);
                    var updateChoice = int.Parse(Console.ReadLine() ?? "0");

                    var clientToUpdate = enrollments.FirstOrDefault(s => s.Id == updateChoice);
                    if (clientToUpdate != null)
                    {
                        Console.WriteLine("What is the client's updated name?");
                        clientToUpdate.Name = Console.ReadLine() ?? "John/Jane Doe";
                    }
                }
                else if (choice.Equals("D", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Which client would you like to delete? ");
                    enrollments.ForEach(Console.WriteLine);
                    var deleteChoice = int.Parse(Console.ReadLine() ?? "0");

                    var clientToRemove = enrollments.FirstOrDefault(s => s.Id == deleteChoice);
                    if (clientToRemove != null)
                    {
                        enrollments.Remove(clientToRemove);
                    }

                }
                else if (choice.Equals("Q", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry that function isn't supported");
                }
            }


        }




        static void ProjectMenu(List<Project> allProjects, List<Client> enrollments)
        {
            //var myProjectService = ClientService.Current;


            while (true)
            {
                Console.WriteLine("C. Create a Project");
                Console.WriteLine("R. List Projects");
                Console.WriteLine("U. Update a Project");
                Console.WriteLine("D. Delete a Project");
                Console.WriteLine("Q. Quit");

                var choice = Console.ReadLine() ?? string.Empty;



                if (choice.Equals("C", StringComparison.InvariantCultureIgnoreCase))
                {
                    //finding a client
                    Console.WriteLine("What is the client you would like to add a project too? ");
                    enrollments.ForEach(Console.WriteLine);
                    var ClientId = int.Parse(Console.ReadLine() ?? "0");

                    //if client exisits
                    var clientToProject = enrollments.FirstOrDefault(s => s.Id == ClientId);
                    if (clientToProject != null)
                    {
                        Console.WriteLine("Client found...");

                        Console.WriteLine("Enter Project id: ");
                        var projectId = int.Parse(Console.ReadLine() ?? "0");

                        Console.WriteLine("Enter Project short name: ");
                        var shortName = Console.ReadLine();

                        Console.WriteLine("Enter Project longname: ");
                        var longName = Console.ReadLine();



                        allProjects.Add(new Project
                        {
                            Id = projectId,
                            ShortName = shortName ?? "0000",
                            LongName = longName ?? "00000000",
                            OpenDate = DateTime.Now,
                            ClosedDate = null,
                            IsActive = true,
                            ClientId = ClientId
                        }
                        );


                    }
                    else { Console.WriteLine("This client does not exist"); }


                }
                else if (choice.Equals("R", StringComparison.InvariantCultureIgnoreCase))
                {
                    allProjects.ForEach(Console.WriteLine);

                }
                else if (choice.Equals("U", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Which Project would you like to update? (Enter project Id not client id)");
                    allProjects.ForEach(Console.WriteLine);
                    var updateProject = int.Parse(Console.ReadLine() ?? "0");

                    var ProjectToUpdate = allProjects.FirstOrDefault(s => s.Id == updateProject);
                    if (ProjectToUpdate != null)
                    {
                        Console.WriteLine("What is the Project's updated short name?");
                        ProjectToUpdate.ShortName = Console.ReadLine() ?? "John/Jane Doe";

                        Console.WriteLine("What is the Project's updated long name?");
                        ProjectToUpdate.LongName = Console.ReadLine() ?? "John/Jane Doe";
                    }
                }
                else if (choice.Equals("D", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Which Project would you like to delete? (use ProjectId)");
                    allProjects.ForEach(Console.WriteLine);
                    var deleteChoice = int.Parse(Console.ReadLine() ?? "0");

                    var ProjectToRemove = allProjects.FirstOrDefault(s => s.Id == deleteChoice);
                    if (ProjectToRemove != null)
                    {
                        allProjects.Remove(ProjectToRemove);
                    }

                }
                else if (choice.Equals("Q", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry that function isn't supported");
                }


            }


        }





    }
}