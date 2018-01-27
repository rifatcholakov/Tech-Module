using System;

namespace Stateless
{
    public class Stateless
    {
        public static void Main()
        {            
            while(true)
            {
                string state = Console.ReadLine();

                if (state == "collapse")
                {
                    return;
                }

                string fiction = Console.ReadLine();               

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, "");

                    if (fiction.Length > 0) fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0) fiction = fiction.Remove(fiction.Length - 1, 1);

                    if(fiction.Length < 1)
                    {
                        if(state.Length == 0)
                        {
                            Console.WriteLine("(void)");
                        }
                        else
                        {
                            Console.WriteLine(state.Trim());
                        }                        
                    }                    
                }                
            }
        }
    }
}
