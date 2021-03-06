﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class LBoard
    {

        public static string ConnnectionString = ConnnectionString = @"Data Source=SE02-OF-WL2999\NEWSQLEXPRESS;Initial Catalog=MineSweeper;Integrated Security=True";
        public bool IsTopTen(int Time, string Game)
        {
            string conStr = ConnnectionString;
            float ActuallTime = (float)Time / 100;
            using (var Con = new SqlConnection(conStr))
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand($@" select top 10 
                                                                                [Time]
                                                                            FROM LeaderBoard
                                                                            where Game = @Game
                                                                            order by time asc", Con);
                    command.Parameters.AddWithValue("@Game", Game);

                    var TopTen = command.ExecuteReader();
                    int ammount = 0;
                    while (TopTen.Read())
                        ammount++;
                    Con.Close();
                    if (ammount < 10)
                        return true;
                    Con.Open();
                    command = new SqlCommand($@"SELECT top 1 * from ( select top 10 
                                                                                [Time]
                                                                            FROM LeaderBoard
                                                                            where Game = @Game
                                                                            order by time asc) as ID
                                                                            order by time desc", Con);
                    command.Parameters.AddWithValue("@Game", Game);
                    float GetTime = float.Parse(command.ExecuteScalar().ToString());
                    Con.Close();

                    if (GetTime < ActuallTime)
                        return false;
                    else
                        return true;
                    
                }
                catch (System.Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return false;
                }
            }
        }
    

        public List<LeaderBoard> GetLeaderBoard(string Game)
        {

            List<LeaderBoard> LeaderBoard = new List<LeaderBoard>();
            string conStr = ConnnectionString;
            string CommandString = "";
            using (var Con = new SqlConnection(conStr))
            {
                try
                {
                    Con.Open();
                    if (Game != "")
                    {
                        CommandString = $@"SELECT [Time]
                                                                  ,[Name]
                                                                  ,[Game]
                                                              FROM [LeaderBoard]
                                                              where Game =  @Game
                                                              order by [Time] asc";
                    }
                    else if (Game == "")
                    {
                        CommandString = $@"SELECT[Time]
                                                ,[Name]
                                                ,[Game]
                                                FROM[LeaderBoard]
                                                order by[Time] asc";
                    }

                        SqlCommand command = new SqlCommand(CommandString, Con);

                    if(Game != "")
                    command.Parameters.AddWithValue("@Game", Game);
                    int placement = 1;
                    var EventLog = command.ExecuteReader();
                    while (EventLog.Read())
                    {
                        if (EventLog.HasRows)
                        {
                            var row = new LeaderBoard();
                            row.Time = float.Parse(EventLog.GetValue(0).ToString());
                            row.Name = EventLog.GetValue(1).ToString();
                            row.Game = EventLog.GetString(2);
                            row.Placement = placement;
                            placement++;
                            LeaderBoard.Add(row);
                        }
                    }
                    Con.Close();
                }
                catch (System.Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return null;
                }
            }
            return LeaderBoard;
        }
        public void AddToLeaderBoard(int Time, string name, string Game)
        {
            string conStr = ConnnectionString;
            float ActualTime = (float)Time / 100;
            using (var Con = new SqlConnection(conStr))
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand($@"INSERT INTO LeaderBoard
                                                                        ([Time]
                                                                        ,[Name]
                                                                        ,[Game])
                                                                    VALUES
                                                                        (@Time
                                                                        ,@Name
                                                                        ,@Game)", Con);
                    command.Parameters.AddWithValue("@Time", ActualTime);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Game", Game);
                    command.ExecuteNonQuery();


                }
                catch (System.Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                }

            }
        }
    }
}

