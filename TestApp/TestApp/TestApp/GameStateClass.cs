﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class GameStateClass
    {
        private int[] ReadText(String file, int typeSelector, int eventNumber = -1)
        {
            //Reads text from file to return either Events or Options
            int[] ReturnArray = new int[30];
            //if tS == 0, returns Events
            if (typeSelector == 0)
            {
                //returns array of all event #'s
            }
            //if tS == 1, returns Options
            else if (typeSelector == 1)
            {
                //returns option numbers that match with event number
            }

            return ReturnArray;
        }

        private List<List<List<int>>> CreateEventList()
        {
            //Creates the Event List by utilizing ReadText to get specifications
            //int[] EventsArray = this.ReadText(file,0)
            int[] EventsArray = new int[] { 1, 2, 3, 4 };
            //EventsArray determined by ReadText(tS=0)

            List<List<List<int>>> ReturnList = new List<List<List<int>>>();



            for (int i = 0; i <= EventsArray.Length - 1; i++)
            {
                List<List<int>> Temp = new List<List<int>>();
                //This 0 is always 0 at initialization to show that this event has not happened yet
                Temp.Add(new List<int> { 0 });
                //This next List is determined by ReadText returning options
                //Temp.Add(ReadText(file,typeSelector = 1, eventNumber = x);
                ReturnList.Add(Temp);
            }


            return ReturnList;
        }

        private List<List<int>> CreateOptionList()
        {
            //Creates the Option List by utilizing ReadText to get a list of options
            //int[] OptionsArray = this.ReadText(file,1)
            int[] OptionsArray = new int[] { 1, 2, 3, 4 };
            //OptionsArray determined by ReadText(tS=1)

            List<List<int>> ReturnList = new List<List<int>>();

            for (int i = 0; i <= OptionsArray.Length - 1; i++)
            {
                List<int> Temp = new List<int>();
                //First Value in this list shows whether or not the player has chosen this choice before (Always 0 on initialization)
                Temp.Add(0);
                //Second Value is whether this option is available to the user at the current time (0 or 1 on initialization)
                Temp.Add(1);
                //This next List is determined by ReadText returning options
                //Temp.Add(ReadText(file,typeSelector = 1, eventNumber = x);
                ReturnList.Add(Temp);


                /*
                 * FINAL THOUGHTS 
                 * Options list could be triple deep list (Could have a list of next events in addition to booleans)
                 * Find out how the text is going to be formatted
                 * Find out how to import text 
                 * winState/loseState implementation
                 * Ship class in GameState?
                 * Saving/Loading 
                 * 
                 * 
                 */

            }


            return ReturnList;
        }

        int[,][] EventArray = new int[,][]
        {
            // Declares a 3D array with the first inner array being a boolean value stating whether event has happened already or not, and the second inner array being option for the Event
            { new[] { 0 }, new[] { 1,2,3,4 } },
            { new[] { 0 }, new[] { 5,6,7,8 } },
            { new[] { 0 }, new[] { 9,10,11,12 } },
            { new[] { 0 }, new[] { 13,14,15,16 } }
        };

        int[][] OptionArray = new int[][]
        {
            new int[] {1,3,5,7,9},
            new int[] {0,2,4,6},
            new int[] {11,22}
        };
    }
}
