using System;

public class studentUI
{
	
	public studentUI()
	{
		

	}

	public static void mainMethod()
    {
		student stud = new student();

    }

	public static void displayData()
    {
		String[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" +
				"Friday", "Saturday"};
		String name;
		String ID;
		Console.WriteLine("Please tell us your name!: ");
		name = Console.ReadLine();
		Console.WriteLine("Please tell us your ID!: ");
		ID = Console.ReadLine();
		int IDInt = Convert.ToInt32(ID);
		double[] hours = new double[7];

		//This displays the name id and the array contents
		Console.WriteLine("Welcome to the Student Study Application coded by Matthew Perez!");
		Console.WriteLine("You are:\t" + name);
		Console.WriteLine("Your ID is:\t" + IDInt);
		Console.WriteLine("In this application you will be prompted to enter the number of hours");
		Console.WriteLine("You have studied for in a week, the program will then calculate an average");
		Console.WriteLine("Amount you have studied for and then display the results of said calculation to you");
		Console.WriteLine("\n\n\nPlease type in the hours you have studied for: ");
		for (int i = 0; i < days.Length -1; i++)
        
		{
			String upCase = days[i].ToUpper();
			Console.WriteLine("You are currently assigning the amount of hours you worked on the day of: ");
			Console.WriteLine(upCase);
			Console.WriteLine("How many hours did you work on " + upCase );
			Console.WriteLine("Enter here: ");
		    hours[i] = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("You have entered: \t" + hours);
			Console.WriteLine("We will now go to the next day or exit this loop after all days have been assigned");
		}


		double avgHours = displayAverage(hours);

		String userChoice;
		Console.WriteLine("Type in Yes to restart or No to exit the program: ");
		userChoice = Console.ReadLine();
		userChoice.ToLower();
		Console.WriteLine("You entered: " + userChoice);
		switch(userChoice)
        {
			case "yes":
				displayData();
				break;
			case "no":

				break;
        }
    }

	public double displayAverage(double[] hour)
    {
		double total = 0;
		foreach ( double ele in hour)
        {
			total = hour[ele];
        }
		double AVG = total;

		return AVG;
    }

	public void fillHours()
    {

    }
}
