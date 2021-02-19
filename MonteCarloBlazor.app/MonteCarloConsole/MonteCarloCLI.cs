using System;
using System.Collections.Generic;
using System.Text;
using MonteCarloConsole.Classes;

namespace MonteCarloConsole
{
    public class MonteCarloCLI
    {

        //to start getting input per basic web app
        //Start Amount, Annual Investment +/-, Average Annual Return, Portfolio STD Deviation
        //  how many years to Sim
        //leave out rebalancing for now as it does not apply without individual asset classes

        public void RunMonteCarlioCLI()
        {
           

            int initialInvestment = PromptForInt("Please enter initial amount of portfolio");
            int annualInvestment = PromptForInt("Please enter annual investment +/-");
            int timePeriod = PromptForInt("Please enter time period in years");
            double averageAnnualReturn = PromptForDouble("Please enter average annual return as a double ex 0.1 for 10%");
            double portfolioSTD = PromptForDouble("Please enter standard deviation of portfolio as double ex 0.1 for 10");

            MonteCarlo monteCarlo = new MonteCarlo(initialInvestment, annualInvestment, timePeriod, "None", averageAnnualReturn, portfolioSTD);

            monteCarlo.RunOneSimulation();

            Console.WriteLine("Start amount: " + monteCarlo.Simulations[0].StartAmount);
            Console.WriteLine("End amount: " + monteCarlo.Simulations[0].EndAmount);
            Console.WriteLine("Success ? : " + monteCarlo.Simulations[0].Result);

        }

        public int PromptForInt(string prompt)
        {
            int returnInt = -1;

            bool validInput = false;

            do
            {
                Console.Write(prompt + ": ");

               
                    try
                    {
                        returnInt = int.Parse(Console.ReadLine());
                        validInput = true;
                        return returnInt;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You did not enter an integer"); 
                    }

            } while (!validInput);

            return returnInt;

           
        }

        public double PromptForDouble(string prompt)
        {
            double returnDouble = -1.00;

            bool validInput = false;

            do
            {
                Console.Write(prompt + ": ");


                try
                {
                    returnDouble = double.Parse(Console.ReadLine());
                    validInput = true;
                    return returnDouble;
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter an integer");
                }

            } while (!validInput);


            return returnDouble;

        }

    }

}
