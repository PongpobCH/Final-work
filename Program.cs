using System;

class Program{

    static void Main(){

        
        user();
        
    
    }

    public static void user()
    {
        bool haveaccount, guest;
        string email, password, a, b;

        haveaccount = true;
        guest = false;

        email = "Checkhere";
        
        password = "123"; 

        user user = new user(email,password, haveaccount, guest);

        Console.WriteLine("email = ");
       
        a = Console.ReadLine();

        Console.WriteLine("Password =");
        
        b = Console.ReadLine();
        
        if( email == a)

            {
                if(password == b)
                
                {
                    Console.WriteLine("Log in!!");
                }

                else
                {
                    Console.WriteLine("Account or Password Wrong");
                }
                

            }
        
            else
                {
                    Console.WriteLine("Account or Password Wrong");
                }   
        

    }



















     

}

