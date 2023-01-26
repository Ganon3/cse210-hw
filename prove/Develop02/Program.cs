using System.IO; 
using System.Collections.Generic;


class Program {
    static void Main(string[] args, string generate_random_prompts)
    {
        // this is for seting up the app seting up the app; 
        // making the classes, geting the dait, seting up temporary strings and the storage list
        Console.WriteLine(""); 
        Console.WriteLine(""); // space space
        Read_and_Write to_write = new Read_and_Write();
        Read_and_Write to_show_last_entries = new Read_and_Write();
        Prompts randon_prompts = new Prompts();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        List <string>  list_to_store_temporaly_my_entries = new List<string>();
        string entries;
        string validation_answers;
        string validation_loop_on_going;
        

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please write a number from 1 to 6 to select one of the following options: ");

        string app_on = "yes" ;
        do {
            Console.WriteLine("1._ Write a new entry");
            Console.WriteLine("2._ Display currents entries");
            Console.WriteLine("3._ Delete currents entries");
            Console.WriteLine("4._ Load a journal");
            Console.WriteLine("5._ Save entries in a journal");
            Console.WriteLine("6._ Quit");
            Console.WriteLine("");
            Console.WriteLine("What we are doing today?:");
            Console.WriteLine("");

            string my_choice = Console.ReadLine()!;
            string generate_random_prompts = randon_prompts.randon_prompts();

            if (my_choice == "1") // write new enrty
                {
                //idea took of https://www.codeproject.com/Questions/1180559/How-do-I-add-at-an-array-with-user-input 
                Console.WriteLine($"{generate_random_prompts} (Press enter to finish): ");
                entries = Console.ReadLine()!;
                list_to_store_temporaly_my_entries.Add($"{dateText} - {generate_random_prompts}");
                list_to_store_temporaly_my_entries.Add(entries);
                list_to_store_temporaly_my_entries.Add("----------------------------------------");
                list_to_store_temporaly_my_entries.Add("");
                }

            else if (my_choice == "2") // Display currents entries
                {
                if (list_to_store_temporaly_my_entries.Count < 1)
                    {
                    Console.WriteLine("I'm sorry, you don't have any entry yet.");
                    Console.WriteLine("Do you want to do something else?: ");

                    }
                else 
                    {
                    Console.WriteLine("The entries you have write so fare are: ");
                    foreach (string each_entry in list_to_store_temporaly_my_entries)
                        {
                        Console.WriteLine(each_entry);
                        }
                    }   
                Console.WriteLine("");
                }

            else if (my_choice == "3") // Delete currents entries
                {
                Console.WriteLine("");                    
                if (list_to_store_temporaly_my_entries.Count < 1)
                    {
                        Console.WriteLine("I'm sorry, you don't have any entry to delete yet.");
                        Console.WriteLine("");
                        Console.WriteLine("Do you want to do something else?: ");
                    }
                else 
                    {   Console.WriteLine("");
                        validation_loop_on_going = "yes";
                        do{
                            Console.WriteLine("Do you want to delete all your current entries? (y/n): ");
                            validation_answers = Console.ReadLine()!;
                            if (validation_answers == "y")
                            {//https://www.techiedelight.com/es/delete-all-items-from-a-list-in-csharp/#:~:text=Una%20soluci%C3%B3n%20simple%20y%20directa,Clear()%20m%C3%A9todo.
                                list_to_store_temporaly_my_entries.Clear(); 
                                Console.WriteLine("");
                                Console.WriteLine("All current not saved entries were deleted.");
                                validation_loop_on_going = "no";

                            } else {
                                
                                validation_loop_on_going= validation_method(validation_loop_on_going, validation_answers);
                            }
                        }while (validation_loop_on_going == "yes");   
                    }   
                }
            else if (my_choice == "4") // Load a journal
                {
                Console.WriteLine("");
                Console.WriteLine("Please enter the name of the journal you would like to open: ");
                string journal_name = Console.ReadLine()!;

                    if (File.Exists(journal_name))
                        {
                        to_show_last_entries._myfile =journal_name;
                        to_write._myfile = journal_name;
                        to_show_last_entries.for_reading_the_file();
                        Console.WriteLine("");
                        Console.WriteLine($"Journal {journal_name} loaded");
                        list_to_store_temporaly_my_entries.Clear();
                        Console.WriteLine("Do you want to do something else?: ");
                        Console.WriteLine("");
                        } 
                    else //if does not exist we are going to create
                        {
                        Console.WriteLine($"There doe not exist a {journal_name} file.");
                        validation_loop_on_going = "yes";
                        do {
                            Console.WriteLine($"Would you like to create a journal called {journal_name} (y/n): ");
                            validation_answers = Console.ReadLine()!;
                            if (validation_answers == "y")
                            {   
                                to_write._myfile = journal_name;
                                to_write.creating_a_file();
                                list_to_store_temporaly_my_entries.Clear();
                                Console.WriteLine($"The {journal_name} has been created.");
                                Console.WriteLine("");
                                validation_loop_on_going = "no";
                            } else {
                                
                                validation_loop_on_going= validation_method(validation_loop_on_going, validation_answers);
                            } 
                        }while (validation_loop_on_going == "yes");
                    } 
                }
            else if (my_choice == "5") // Save entries in a journal
                {
                Console.WriteLine("");
                Console.WriteLine("Enter the name of the journal to save the entries. ");
                to_write._myfile = Console.ReadLine()!;
                if (File.Exists(to_write._myfile))
                    {   
                    validation_loop_on_going = "yes";
                    do {
                        Console.WriteLine($"Already exist a {to_write._myfile} Are you sure you wish overwrite it?: (y/n) ");
                        validation_answers = Console.ReadLine()!;
                        if (validation_answers == "y")
                        {   
                            validation_loop_on_going = "no";
                            foreach (string a_entry in list_to_store_temporaly_my_entries)
                                {   
                                    to_write._writed_entry = a_entry;
                                    to_write.writing_on_file(generate_random_prompts, dateText); 
                                }
                        } else {
                                
                                validation_loop_on_going= validation_method(validation_loop_on_going, validation_answers);
                            } 

                    }while(validation_loop_on_going == "yes");
                    
                    } 
                else //if does not exist we are going to create
                    {
                    Console.WriteLine($"There is not exist a {to_write._myfile} Journal");
                    validation_loop_on_going = "yes";
                    do
                        {
                        Console.WriteLine($"Would you like to create a journal called {to_write._myfile}: (y/n)");
                        validation_answers = Console.ReadLine()!;
                        if (validation_answers == "y")
                        {
                            to_write.creating_a_file();
                            if (list_to_store_temporaly_my_entries.Count > 0)
                                foreach (string a_entry in list_to_store_temporaly_my_entries)
                                {   
                                    to_write._writed_entry = a_entry;
                                    to_write.writing_on_file(generate_random_prompts, dateText); 
                                }
                            validation_loop_on_going = "no";
                        } else {

                                validation_loop_on_going= validation_method(validation_loop_on_going, validation_answers);
                            }    

                        }while (validation_loop_on_going == "yes");
                        
                    }
                Console.WriteLine($"{to_write._myfile} has been saved.");
                Console.WriteLine("");
                }
            else if (my_choice == "6") // Quit
                {
                    Console.WriteLine("");
                    app_on = "no";
                    Console.WriteLine("See you next time.");
                    Console.WriteLine("");
                }
            else // this is if user does not put 1 2 3 4 5 or 6
                {
                    Console.WriteLine("");
                    Console.WriteLine("This is not a valid answer, please digit a number between 1 to 6.");
                    Console.WriteLine("");
                }
                    
            }while (app_on == "yes");     
              
    }

    // this next part is funtions 
    // becasue i cant fined a way to put funtions in the own file

   /*
   static string validation_method( string loop, string answer) // this is work with the do while loop in the options 1 threw 6
    {
        if (answer == "n") 
            {
            Console.WriteLine("Do you want to do something else?: ");
            loop = "no";
            return loop;
            } 
        else
            {
            Console.WriteLine("Invalid input, please asnwer with the letter (y) or (n) to coninute.");
            Console.WriteLine("");
            return loop;
            }    
    }  
    */    
}

