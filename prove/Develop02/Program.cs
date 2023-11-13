using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal myJournal = new Journal();
        string menu = "Please select one of the following choices:" + 
        "\n1. Write\n2. Display\n3. Edit\n4. Load\n5. Save\n6. Quit\n" + 
        "What would you like to do? ";

        bool running = true;
        while (running)
        {
            if (running)
            {
                Console.Write(menu);
            }
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                Entry newEntry = new Entry();
                newEntry._prompt = new PromptGenerator().GeneratePrompt();
                Console.WriteLine(newEntry._prompt);
                Console.Write(">");
                newEntry._response = Console.ReadLine();
                myJournal.AddEntry(newEntry);
                break;

                case 2:
                myJournal.Display();              
                break;

                case 3:
                Console.WriteLine("What entry number do you want to change?");
                int entryNum = int.Parse(Console.ReadLine());
                myJournal.ChangeEntry(entryNum);              
                break;

                case 4:
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
                break;

                case 5:
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
                break;

                case 6:
                default:
                running = false;
                break;
            }
        } 
    }
}
/*
Welcome to the Journal Program!
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do?
*/