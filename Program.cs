using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace GraduateTally
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalTally = 0, maleTally = 0, femaleTally = 0, asianTally = 0, anxietyTally = 0, asianAmericanTally = 0, mentalTally = 0, 
                suicideTally = 0, depressionTally = 0, illnessTally = 0, killTally = 0, twitterTally = 0, depressedAsianTally = 0,
                southAsianTally = 0, southeastAsianTally = 0;
            StreamReader sr = new StreamReader("/Users/jacobbyerline/Desktop/cat.txt");
            string File = sr.ReadToEnd();
            sr.Close();


            string newFile = File.Replace(':', ' ');
            newFile = newFile.Replace('"', ' ');
            newFile = newFile.Replace('#', ' ');
            newFile = newFile.Replace('.', ' ');
            newFile = newFile.Replace('!', ' ');
            newFile = newFile.Replace('?', ' ');
            newFile = newFile.Replace('…', ' ');
            newFile = newFile.Replace('“', ' ');
            newFile = newFile.Replace('/', ' ');
            newFile = newFile.Replace('\\', ' ');
            newFile = newFile.Replace('*', ' ');
            newFile = newFile.Replace('-', ' ');
            newFile = newFile.Replace(',', ' ');
            newFile = newFile.Replace('@', ' ');
            newFile = newFile.Replace('$', ' ');
            newFile = newFile.Replace('%', ' ');
            newFile = newFile.Replace('^', ' ');
            newFile = newFile.Replace('&', ' ');

            StreamWriter outfile = new StreamWriter("/Users/jacobbyerline/Desktop/NewGraduateProjectData.txt");

            outfile.Write(newFile);

            List<string> result = newFile.Split(' ', '\n').ToList();

            foreach (string keyword in result)
            {
                if (keyword == "male" || keyword == "female")
                {
                    totalTally++;

                    if ( keyword == "male")
                    {
                        maleTally++;
                    }
                    else if (keyword == "female")
                    {
                        femaleTally++;
                    }
                }
                else if(keyword == "asian" || keyword == "Asian" || keyword == "Asians" || keyword == "asians")
                {
                    asianTally++;
                }
                else if (keyword == "anxiety" || keyword == "Anxiety" || keyword == "Anxieties" || keyword == "anxieties")
                {
                    anxietyTally++;
                }
                else if (keyword == "american" || keyword == "americans" || keyword == "American" || keyword == "Americans")
                {
                    asianAmericanTally++;
                }
                else if (keyword == "health" || keyword == "Health")
                {
                    mentalTally++;
                }
                else if (keyword == "suicide" || keyword == "Suicide")
                {
                    suicideTally++;
                }
                else if (keyword == "depression" || keyword == "Depression")
                {
                    depressionTally++;
                }
                else if (keyword == "illness" || keyword == "Illness")
                {
                    illnessTally++;
                }
                else if (keyword == "kill" || keyword == "kills" || keyword == "Kill" || keyword == "Kills")
                {
                    killTally++;
                }
                else if (keyword == "twitter" || keyword == "Twitter")
                {
                    twitterTally++;
                }
                else if (keyword == "Depressed Asian" || keyword == "depressed Asian" || keyword == "depressed asian" )
                {
                    depressedAsianTally++;
                }
                else if (keyword == "South Asian" || keyword == "south Asian" || keyword == "south asian")
                {
                    southAsianTally++;
                }
                else if (keyword == "Southeast Asian" || keyword == "southeast Asian" || keyword == "southeast asian")
                {
                    southeastAsianTally++;
                }
            }

            outfile.Close();

            int redditTally = totalTally - twitterTally;

            StreamWriter tallyoutfile = new StreamWriter("/Users/jacobbyerline/Desktop/KeywordTally.txt");

            tallyoutfile.WriteLine("Total Posts: " + "\t" + "\t" + "\t" + "\t" + totalTally);
            tallyoutfile.WriteLine("Total Male Posts: " + "\t" + "\t" + "\t"  + maleTally);
            tallyoutfile.WriteLine("Total Female Posts: " + "\t" + "\t" + "\t"  + femaleTally);
            tallyoutfile.WriteLine("Total Posts from Twitter: " + "\t" + "\t" + twitterTally);
            tallyoutfile.WriteLine("Total Posts from Reddit: " + "\t" + "\t" + redditTally);
            tallyoutfile.WriteLine("Total Occurrences of \"asian\" " + "\t"+ "\t" + asianTally);
            tallyoutfile.WriteLine("Total Occurrences of \"asian american\" " + "\t" + asianAmericanTally);
            tallyoutfile.WriteLine("Total Occurrences of \"anxiety\" " + "\t" + "\t" + anxietyTally);
            tallyoutfile.WriteLine("Total Occurrences of \"mental health\" " + "\t" + mentalTally);
            tallyoutfile.WriteLine("Total Occurrences of \"suicide\" " + "\t" + "\t" + suicideTally);
            tallyoutfile.WriteLine("Total Occurrences of \"depression\" " + "\t" + depressionTally); 
            tallyoutfile.WriteLine("Total Occurrences of \"mental illness\" " + "\t" + illnessTally);
            tallyoutfile.WriteLine("Total Occurrences of \"kill\" " + "\t" + "\t" + killTally);
            tallyoutfile.WriteLine("Total Occurrences of \"depressed asian\" " + "\t" + depressedAsianTally);
            tallyoutfile.WriteLine("Total Occurrences of \"south asian\" " + "\t" + southAsianTally);
            tallyoutfile.WriteLine("Total Occurrences of \"southeast asian\" " + "\t" + southeastAsianTally);
            tallyoutfile.WriteLine("\nAPI Search Parameters: \n\n Network - Twitter & Reddit \n\n Language - English \n\n Keywords - \"Asian\" + anxiety," +
            	" asian american, mental health, suicide, depression, depressed, mental illness, killmyself \n" + 
                " \n Sentiment: Pos, Neg, Neutral \n\n Gender Accuracy - Above 80%");

            tallyoutfile.Close();

        }
    }
}