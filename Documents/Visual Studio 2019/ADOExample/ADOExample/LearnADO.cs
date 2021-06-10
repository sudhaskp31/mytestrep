using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ADOExample
{
    public class LearnADO
    {
        readonly string connectionString = @"Data source=USER-PC;user id=sa;password=Sairam123;Initial Catalog=dbCompany";
        readonly SqlConnection connection;
        List<Skill> skills;
        public LearnADO()
        {
            connection = new SqlConnection(connectionString);
        }
        public void CheckConnectedADO()
        {
            skills = new List<Skill>();
            //Query
            string strCommand = "select * from Skills";
           //Initializing the command with th required properties
            SqlCommand sqlCommand= new SqlCommand();
            //Providing the connection to the command (or)linking the connection and the command object
            sqlCommand.Connection = connection;
            //Providing the command text
            sqlCommand.CommandText = strCommand;
            //opening the connection or establishing the connection
            connection.Open();
            Skill skill;
            //pointing the data from the database to the datareader
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            //reading the data record by record
            while(dataReader.Read())
            {
                skill = new Skill();
                //using the index to access the columns of teh  current row
                skill.SkillName= dataReader[0].ToString();
                skill.Skill_description = dataReader[1].ToString();
                skills.Add(skill);

            }
            //winding up the connection
            connection.Close();
            PrintSkills();
        }
        public void CheckDisConnectedADO()
        {
            skills = new List<Skill>();
            //Query
            string strCommand = "select * from Skills";
            //Initializing the command with th required properties
            SqlCommand sqlCommand = new SqlCommand();
            //Providing the connection to the command (or)linking the connection and the command object
            sqlCommand.Connection = connection;
            //Providing the command text
            sqlCommand.CommandText = strCommand;
            //adapter to connect with database
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //providing the select query
            dataAdapter.SelectCommand = sqlCommand;
            //to store result locally dataset
            DataSet dataset = new DataSet();
            //use tee data adapter to connect-> fetch th data-> put it in teg data set->disconnect
            dataAdapter.Fill(dataset);
            Skill skill;
            foreach(DataRow item in dataset.Tables[0].Rows)
            {
                skill = new Skill();
                //using teh index to access the columns of the curret row
                skill.SkillName = item[0].ToString();
                skill.Skill_description = item[1].ToString();
                skills.Add(skill);
            }
            PrintSkills();



        }
        public void PrintSkills()
        {
            foreach(var item in skills)
            {
                Console.WriteLine(item);
            }
        }

    }
}
