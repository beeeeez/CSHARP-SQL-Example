//Christopher Brown, Week 3 Exam Project 1, 2/6/18, C# SE245.54



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        /*Alrighty, I figured yahtzee would give me the grounds to fill all the lab requirements easily.
         * Which it totally did, just turned out to take a little longer and was a little harder than I thought. 
         * I got a good ways through the program, but I hit a wall for a little while. 
         * Turns out the logic I thought I could use for the lower card score reading was not right.
         * The upper card logic (1 - 6), the diceroll, and the main function I wrote myself, it was pretty straightforward
         * The lower card logic (7 - 12) I borrowed from - https://www.codeproject.com/Articles/8657/A-Simple-Yahtzee-Game
         * That guide was awesome for explaining how to read those arrays. And those conditionals are nuts.
         * 
         * That being said, this is a pretty rough model of yahtzee. If I had dedicated more time to this,
         * I would've liked to add a yahtzee pull out mechanic that just gave you 50 points as soon as you match all 5 in the dice roll function
         * Maybe cleaned up the console a bit more and seen how I could've used the counters more efficiently and used less of them.
         * Also, calculate a clear winner? I just print the scores out. 
         * 
         * 
         * Just a little explanation of whats going on:
         * 
         * The main function generates the dice array (dice[]), the list array for the names of the players, 
         * the array for the players scores(scoreNum[]), and the boolean table for which score categories have been chosen already (scoreBool[,])
         * it gathers players names, then it generates the dice array, and sends it to the diceroll function. 
         * 
         * 
         * the diceroll function essentially just assigns value to the 5 slots of the dice array. It goes through the proper prompts for how the game works
         * generates its own save[] to determine which dice are getting saved by the user each roll.
         * once it populates the arrays and the user ends the rolling sequence of their round, it just breaks off and returns nothing
         * because the dice[] is referenced, so as it's populating the dice[] its changing its values by address and not by passing values across functions
         * 
         * so when it goes back to main, 
         * it asks the scoring sheet function what the value of the score is, it also sends the function dice[], ref scoreBool[,], name, hardCount.
         * 
         * the scoring sheet generates a list of all the scoring categories and prompts the user for their selection
         * then, using if and else if statements, it properly grabs their selection and generates total points for whatever the parameters are
         * it then sends those points back to main
         * 
         * 
         * main then takes those points and adds it to the total corresponding to the active player
         * 
         * this action loops for each player in the game
         * then it loops through each player 13 more times, until every field is filled 
         * then it asks the void function to output text (the game is over) 
         * and then it displays each player and their corresponding score. 
         * 
         * 
         * 
         * 
         * 
         * 
         * */

           
        /*put this on hold for now
    static int rolltheDice(int[] dice)
    {

        Random diceRoll = new Random();
        int hold=1;
        bool[] diceSave = new bool[4];

        string holdMe;

        for(int i=0; i<5; i++)
        {
            dice[i] = diceRoll.Next(1, 7);
            Console.WriteLine($"\nDice #{hold} is : {dice[i]} !");
            hold++;
        }//end of dice assignment array loop thing
        Console.Write("\n\n\n");
        hold = 1;
        for (int i =0; i<5; i++)
        {

            Console.Write($"\nDo you want to SAVE dice #{hold}? ('y' for yes) : ");
            holdMe = Console.ReadLine();

            if(holdMe != "y" && holdMe!= "Y")
            {
                dice[i] = diceRoll.Next(1, 7);
                diceSave[i] = false;
            }
            else
            {
                diceSave[i] = true;
            }


            hold++;

        }//2nd dice roll end

        Console.Write("\n\n\n");
        hold = 1;

        for(int i = 0; i<5; i++)
        {
            if (diceSave[i] == true)
            {
                Console.Write($"\nDice #{hold} is {dice[i]} *SAVED");
            }
            else
            {
                Console.Write($"\nDice #{hold} is {dice[i]} !");
            }

        }//end of reprint out

        for (int i = 0; i < 5; i++)
        {
            if(diceSave[i] == false)
            {

                Console.Write($"\nDo you want to SAVE dice #{hold}? ('y' for yes) : ");
                holdMe = Console.ReadLine();
                if (holdMe != "y" && holdMe != "Y")
                {
                    dice[i] = diceRoll.Next(1, 7);
                }


            }


        }//end of last reroll prompt




    }//end of roll the dice function
    */



        static void gameOver()//heh, this my cheesy straight void function. just prints to console.
        {
            Console.Clear();
            Console.Write("The game is over!");
        }//end of gameover function ---------------------------------------------------------------------------------------------------------------



            static int scoringSheet(int[] dice, ref bool[,] scoreBool, string name, int hardCount)//ok, even though there is ref here, it returns an int to main, so i consider this my return function
        {
            Console.Clear();
            bool keepGoing = true, checkMe;
            string sel;
            int x = 0, totalScore=0, winCon, hold=1;
            List<string> scoringCats = new List<string>();
            scoringCats.Add("Aces");
            scoringCats.Add("Twos");
            scoringCats.Add("Threes");
            scoringCats.Add("Fours");
            scoringCats.Add("Fives");
            scoringCats.Add("Sixes");
            scoringCats.Add("Three of a Kind");
            scoringCats.Add("Four of a Kind");
            scoringCats.Add("Full House");
            scoringCats.Add("Small Straight");
            scoringCats.Add("Large Straight");
            scoringCats.Add("Yahtzee!");
            scoringCats.Add("Chance");


            do
            {
                
                foreach (string cats in scoringCats)
                {
                    if (scoreBool[hardCount,x] == true)
                    {
                        Console.Write($"\n{hold}--- This Score is Already Claimed ---");
                                                
                    }//end if already checked
                    else
                    {

                        Console.Write($"\n{hold}. {cats}");
                    }//end of else

                    x++;
                    hold++;
                }//end of foreach name in the list loop


                scoringCats.Clear();// is this necessary? so, like, does the list cease to exist as soon as the function ends? or am i just recreating this exact list? or am i making multiple copies? or am I just clearing the list and repopulating it like i hope i am?
                

                Console.Write($"\n\nYour dice values are : ");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"  {dice[i]}  ");

                }//end of dice printout 


                Console.Write($"\n\nWhich scoring category do you want to select for your roll? ( 1 - 13 ) :");
                sel = Console.ReadLine();
                totalScore = 0;



                if (sel == "1")
                {
                    if (scoreBool[hardCount,0] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                        
                    }//end if already checked

                    else
                    {
                        for(int i =0; i < 5; i++)
                        {
                            if (dice[i] == 1){
                                totalScore++;
                            }

                        }//end of dice check

                        scoreBool[hardCount, 0] = true;
                        return totalScore;
                        
                    }


                }//ACES FINSIH




                else if (sel == "2")
                {
                    if (scoreBool[hardCount, 1] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                        
                    }//end if already checked

                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (dice[i] == 2)
                            {
                                totalScore=totalScore+2;
                            }

                        }//end of dice check
                        scoreBool[hardCount, 1] = true;
                        return totalScore;
                       
                    }


                }//TWOS FINSIH


                else if (sel == "3")
                {
                    if (scoreBool[hardCount, 2] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                        
                    }//end if already checked

                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (dice[i] == 3)
                            {
                                totalScore = totalScore + 3;
                            }

                        }//end of dice check
                        scoreBool[hardCount, 2] = true;
                        return totalScore;
                        

                    }


                }//THREES FINSIH

                //it's about right here when I started to regret the decision of programming a yahtzee game so close to due date 

                else if (sel == "4")
                {
                    if (scoreBool[hardCount, 3] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                       
                    }//end if already checked

                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (dice[i] == 4)
                            {
                                totalScore = totalScore + 4;
                            }

                        }//end of dice check
                        scoreBool[hardCount, 3] = true;
                        return totalScore;
                        
                    }


                }//FOURS FINSIH

                else if (sel == "5")
                {
                    if (scoreBool[hardCount, 4] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                        
                    }//end if already checked

                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (dice[i] == 5)
                            {
                                totalScore = totalScore + 5;
                            }

                        }//end of dice check
                        scoreBool[hardCount, 4] = true;
                        return totalScore;
                        
                    }


                }//FIVES FINSIH


                else if (sel == "6")
                {
                    if (scoreBool[hardCount, 5] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                      
                    }//end if already checked

                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (dice[i] == 6)
                            {
                                totalScore = totalScore + 6;
                            }

                        }//end of dice check
                        scoreBool[hardCount, 5] = true;
                        return totalScore;
                        
                    }


                }//SIXES FINSIH


                else if (sel == "7")
                {
                    if (scoreBool[hardCount, 6] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                      
                    }//end if already checked

                    else
                    {//this is starting to get heavy, this is where I really needed to get help from that guide. 
                        //the nested for loop to test the dice array against every number 1-6 was not obvious to me
                        checkMe = false;
                       
                        
                        for(int i =1; i<=6; i++)
                        {
                            winCon = 0;
                            for(int j = 0; j <5; j++)
                            {
                                if (dice[j] == i)
                                {
                                    winCon++;
                                }
                                if (winCon > 2)
                                {
                                    checkMe = true;
                                }

                            }//inside forloop close

                            if (checkMe == true)
                            {
                                for(int j=0; j < 5; j++)
                                {
                                    totalScore += dice[j];
                                }

                            }//end of if


                            else
                            {
                                totalScore = 0;
                            }



                        }//outside for loop close



                        scoreBool[hardCount, 6] = true;
                        return totalScore;
                        
                    }


                }//End of three of a kind



                else if (sel == "8")//same logic as the three of a kind, obv, but just add one more to the win condition counter
                    //the yahtzee check uses the same logic as well
                {
                    if (scoreBool[hardCount, 7] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                     
                    }//end if already checked

                    else
                    {
                        checkMe = false;
                      

                        for (int i = 1; i <= 6; i++)
                        {
                            winCon = 0;
                            for (int j = 0; j < 5; j++)
                            {
                                if (dice[j] == i)
                                {
                                    winCon++;
                                }
                                if (winCon > 3)
                                {
                                    checkMe = true;
                                }

                            }//inside forloop close
                            totalScore = 0;
                            if (checkMe == true)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    totalScore += dice[j];
                                }

                            }//end of if

                            else
                            {
                                totalScore = 0;
                            }





                        }//outside for loop close



                        scoreBool[hardCount, 7] = true;
                        return totalScore;
                        
                    }


                }//End of Four of a Kind


                

                else if (sel == "9")
                {
                    if (scoreBool[hardCount, 8] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                     
                    }//end if already checked

                   

                    else{
                        Array.Sort(dice);
                                       //Ok I sort of understand this, if 0=1=2!=3=4 or 0=1!=2=3=4
                        if ((((dice[0] == dice[1]) && (dice[1] == dice[2])) && // Three of a Kind
                                  (dice[3] == dice[4]) && // Two of a Kind
                                  (dice[2] != dice[3])) ||
                                 ((dice[0] == dice[1]) && // Two of a Kind
                                  ((dice[2] == dice[3]) && (dice[3] == dice[4])) && // Three of a Kind
                                  (dice[1] != dice[2])))
                        {
                            totalScore = 25;
                        }
                        scoreBool[hardCount, 8] = true;
                        return totalScore;
                        
                    }
                }//end of FULL HOUSE CHECK



                else if (sel == "10")
                {
                    if (scoreBool[hardCount, 9]  == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                    
                    }//end if already checked
                    else
                    {
                        Array.Sort(dice);

                        for (int j = 0; j < 4; j++)//from my understanding, what happens is if there is a double, it needs to kick one of them into the dead slot in order not to mess up the conditional below
                        {//i guess it only stops the check in the small straight 
                            int temp = 0;
                            if (dice[j] == dice[j + 1])
                            {
                                temp = dice[j];

                                for (int k = j; k < 4; k++)
                                {
                                    dice[k] = dice[k + 1];
                                }

                                dice[4] = temp;
                            }
                        }//Ok so, this guy knew his math. I'm kind of at a loss of how this is working right here. one long conditional
                        if (((dice[0] == 1) && (dice[1] == 2) && (dice[2] == 3) && (dice[3] == 4)) ||
                                ((dice[0] == 2) && (dice[1] == 3) && (dice[2] == 4) && (dice[3] == 5)) ||
                                ((dice[0] == 3) && (dice[1] == 4) && (dice[2] == 5) && (dice[3] == 6)) ||
                                ((dice[1] == 1) && (dice[2] == 2) && (dice[3] == 3) && (dice[4] == 4)) ||
                                ((dice[1] == 2) && (dice[2] == 3) && (dice[3] == 4) && (dice[4] == 5)) ||
                                ((dice[1] == 3) && (dice[2] == 4) && (dice[3] == 5) && (dice[4] == 6)))
                        {
                            totalScore = 30;
                        }

                        scoreBool[hardCount, 9] = true;
                        return totalScore;
                        
                    }
                }//end of small straight check





                else if (sel == "11")
                {
                    if (scoreBool[hardCount, 10] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                    
                    }//end if already checked

                    else
                    {
                        Array.Sort(dice);

                        if (((dice[0] == 1) &&
                               (dice[1] == 2) &&
                               (dice[2] == 3) &&
                               (dice[3] == 4) &&
                               (dice[4] == 5)) ||
                              ((dice[0] == 2) &&
                               (dice[1] == 3) &&
                               (dice[2] == 4) &&
                               (dice[3] == 5) &&
                               (dice[4] == 6)))
                        {
                            totalScore = 40;
                        }
                        scoreBool[hardCount, 10] = true;
                        return totalScore;
                        
                    }
                }//END OF LARGE STRAIGHT CHECK




                else if (sel == "12")
                {
                    if (scoreBool[hardCount, 11] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                        break;
                    }//end if already checked


                    else
                    {
                        for (int i = 1; i <= 6; i++)
                        {
                            x = 0;
                            for (int j = 0; j < 5; j++)
                            {
                                if (dice[j] == i)
                                    x++;

                                if (x > 4)
                                    totalScore = 50;
                            }
                        }
                        scoreBool[hardCount, 11] = true;
                        return totalScore;
                        
                    }
                }// END OF YAHTZEE


                else if (sel == "13")
                {
                    if (scoreBool[hardCount, 12] == true)
                    {
                        Console.Write($"\nThis score category is already claimed. Please Try Again.");
                   
                    }//end if already checked
                    else
                    {
                        for( int i =0; i<5; i++)
                        {

                            totalScore += dice[i];
                        }
                        scoreBool[hardCount, 12] = true;
                        return totalScore;
                        
                    }


                }//end of chance 


                else
                {

                    Console.Write($"\nThere was a problem with your entry. Please Try Again.");
                }



                } while (keepGoing == true) ; //error control loop doesn't acutally ever stop keepGoing. 

            return totalScore;
        }//end of the scoring sheet function --------------------------------------------------------------------------------------------------------------














        static void rolltheDice(ref int[] dice)// this is my ref function, it changes the dice values for the scorecard to see without actually returning anything
        {
            string holdMe;
            int rollCount, hardCount;
            Random diceRoll = new Random();
            bool[] saveDice = new bool[5];
            
            for (int i=0; i < 5; i++)
            {
                saveDice[i] = false;
            }//initializing the bool array to kick off the rolls


            hardCount = 1;
            for (rollCount = 1; rollCount <= 4; rollCount++)
            {
                
                if(rollCount == 3)
                {
                    Console.Write($"\nThis is your last roll. All values will be locked in for scoring.");

                }
                hardCount = 1;
                for (int i=0; i <5; i++)
                {
                    if (saveDice[i] == false){
                        dice[i] = diceRoll.Next(1, 7);
                        Console.Write($"\nDice #{hardCount} rolled a {dice[i]} ! ");
                    }//end of save check

                    else
                    {
                        Console.Write($"\nYou saved dice #{hardCount} from a previous roll. It was a {dice[i]}.");
                    }
                  
                    hardCount++;
                }//end of dice value output forloop
                hardCount = 1;
                Console.WriteLine();
                
                for (int i = 0; i < 5; i++)
                {
                    if (rollCount < 4)
                    {
                        Console.Write($"\nDo you want to SAVE dice #{hardCount}, with the value of {dice[i]} ? ('y' for yes) : ");
                        holdMe = Console.ReadLine();
                        if (holdMe != "y" && holdMe != "Y")
                        {
                            dice[i] = diceRoll.Next(1, 7);

                        }
                        else
                        {
                            saveDice[i] = true;
                        }
                        hardCount++;
                    }//end of roll count check


                }//end of the save forloop

                hardCount = 0;
                for(int i =0; i <5; i++)
                {
                    if (saveDice[i] == true)
                    {
                        hardCount++;
                    }
                    if (hardCount == 5)
                    {

                        return;//throwing the breaks onnnnn
                    }
                    Console.Clear();
                }//gotta check to see if they saved all their dice


            }//end of rollCount


 


        }//end of rolltheDice function--------------------------------------------------------------------------------------------------









        static void Main(string[] args)// and this is obv my main function, where all the magic begins
        {
            int[] dice = new int[5];
            int numPlayers = 0, hardCount = 1, x = 0, scoreMe = 0, arrCount;
            string holdMeforNow;
            bool check;

            List<string> names = new List<string>();

            do
            {
                Console.Write("Welcome to Chris Brown's Yahtzee thing.\n\nHow many players do you want to play with? (1 - 4) : ");
                holdMeforNow = Console.ReadLine();
                check = Int32.TryParse(holdMeforNow, out numPlayers);
                if (numPlayers <= 0 || numPlayers > 4 || check == false)
                {
                    Console.Write("\n\nThere was an issue with your entry. Please try again");
                    Console.ReadLine();

                }

                Console.Clear();


            } while (numPlayers <= 0 || numPlayers > 4);//appropriate number check



            while (hardCount <= numPlayers)
            {
                Console.Write($"\nWhat is the name of Player #{hardCount} ? : ");
                holdMeforNow = Console.ReadLine();//probably should write a check in to make sure they enter something in, but whatever
                names.Add(holdMeforNow);
                hardCount++;
            }//name collection end;
            hardCount--;
            Console.Clear();
            int[] scoreNum = new int[hardCount];
            bool[,] scoreBool = new bool[hardCount, 14];

            arrCount = 0;
            foreach (string name in names)
            {
                scoreNum[arrCount] = 0;
                while (x > 13)
                {

                    scoreBool[arrCount, x] = false;
                    x++;
                }//end of x while loop

                x = 0;

                arrCount++;
            }//end of foreach Loop

           

            for (int i = 0; i < 13; i++){
                hardCount = 0;
                foreach (string name in names)
                {
                    Console.Clear();
                    Console.Write($"Are you ready to roll the dice {name}? Here we go!");
                    Console.ReadLine();


                    rolltheDice(ref dice);


                    scoreMe = scoringSheet(dice, ref scoreBool, name, hardCount);
                    scoreNum[hardCount] += scoreMe;

                    Console.Write($"\n{name} earned a score of {scoreMe} from the last roll !\n{name} has a total score of {scoreNum[hardCount]} !\n\nPress any key to continue!");
                    Console.ReadLine();


                    hardCount++;
                }//end of foreach loop

            }//end of all the rounds forloop
            hardCount = 0;

            gameOver();

            
            foreach (string name in names)
            {
                Console.Write($"\n{name} scored a {scoreNum[hardCount]}");
                hardCount++;
            }

            Console.ReadLine();



        }//end of main function


      

        }
    }

