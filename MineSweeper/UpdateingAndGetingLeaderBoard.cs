using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class LBoard
    {

        public static string ConnnectionString { get; set; }

        public bool IsTopTen(int Time, string Game)
        {
            ConnnectionString = "Data Source=.;Initial Catalog=MineSweeper;Integrated Security=True";
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
                                                                            order by time desc", Con);
                    command.Parameters.AddWithValue("@Game", Form1.Game);

                    var EventLog = command.ExecuteReader();
                    int ammount = 0;
                    while (EventLog.Read())
                        ammount++;
                    if(ammount < 10)
                        return true;
                    EventLog.Close();
                    command = new SqlCommand($@"SELECT top 1 * from ( 
                                                                        select top 10 
                                                                                [Time]
                                                                            FROM LeaderBoard
                                                                             Game = @Game
                                                                            order by time asc) as ID
                                                                            order by time desc", Con);
                    command.Parameters.AddWithValue("@Game", Game);
                    EventLog = command.ExecuteReader();
                    while(EventLog.Read())
                    {
                        float GetTime = float.Parse(EventLog.GetValue(0).ToString());


                        if (GetTime < ActuallTime)
                            return false;
                        else
                            return true;
                    }
                    return true;
                    Con.Close();
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

            ConnnectionString = "Data Source=.;Initial Catalog=MineSweeper;Integrated Security=True";
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
            ConnnectionString = "Data Source=.;Initial Catalog=MineSweeper;Integrated Security=True";
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
                    var EventLog = command.ExecuteNonQuery();
                    var test = command.ExecuteReader();


                }
                catch (System.Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                }

            }
        }
    }
}

