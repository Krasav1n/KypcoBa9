using System;    
    class DataEngine
    {
        string _fname;
        string[] columns;
        System.Data.OleDb.OleDbConnection connection;
        System.Data.OleDb.OleDbCommand Command;
        System.Data.OleDb.OleDbDataReader Reader;
        public DataEngine(string filename,params string[] columnsNames)
        {
            _fname = filename;
            columns = new string[columnsNames.Length];
            Array.Copy(columnsNames, columns,columnsNames.Length );
        }
        public Angar SelectAllTasks(string tableName) //Select all tasks
        {
            Loader();
            Angar answer;
            answer = new Angar();
            string SQL = "SELECT * FROM "+tableName+" ;";
            Reader = Execute(SQL);
            while (Reader.Read())
            {
                Task temp;
                temp=new Task();
              //DO IT
                temp.Body = Reader.GetValue(Reader.GetOrdinal("Body")).ToString();
                temp.Header  = Reader.GetValue(Reader.GetOrdinal("Header")).ToString();
                temp.Worker = Reader.GetValue(Reader.GetOrdinal("Worker")).ToString();
                temp.ID =Convert.ToInt64( Reader.GetValue(Reader.GetOrdinal("ID")));
                temp.IsDone =(bool) Reader.GetValue(Reader.GetOrdinal("IsDone"));
                temp.Date =Convert.ToDateTime( Reader.GetValue(Reader.GetOrdinal("TargetDate")));
                answer.Storage.Add(temp);
            }
            return answer;
        }
        public System.Collections.ObjectModel.Collection<object> Select(string tableName,
        string columnName, string value, string comma) //Select  items First item is CellsCount
        {
            Loader();
            System.Collections.ObjectModel.Collection<object> answer;
            answer = new System.Collections.ObjectModel.Collection<object>();
            string SQL = "SELECT * FROM " + tableName + "WHERE "+columnName+"="+comma+value +comma+";";
            Reader = Execute(SQL);
            answer.Add(Reader.FieldCount);
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    answer.Add(Reader[i]);
                }
            }
            return answer;
        }
        public System.Collections.ObjectModel.Collection<object> SelectAll(string tableName) //select user. First item is CellsCount
        {
            Loader();
            System.Collections.ObjectModel.Collection<object> answer;
            answer = new System.Collections.ObjectModel.Collection<object>();
            string SQL = "SELECT * FROM " + tableName + ";";
            Reader = Execute(SQL);
            answer.Add(Reader.FieldCount);
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    answer.Add(Reader[i]);
                }
            }
            return answer;
        }
        private System.Data.OleDb.OleDbDataReader Execute(string command)
        {
            Command = connection.CreateCommand();
            Command.CommandText = command;
            return Command.ExecuteReader();
        }
        private void Loader()
        {
            if (connection == null)
                connection = CreateConnection();
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }
        private System.Data.OleDb.OleDbConnection CreateConnection() //Create connection
        {
            System.Data.OleDb.OleDbConnection c;
            c = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+_fname+";");
            return c;
        }
        public void InsertNewTask(Task t,string tableName)
        {
            Loader();
            string sql = "INSERT INTO "+tableName+" (TargetDate,Header,Body,Worker,IsDone) VALUES ('"+t.Date.ToShortDateString()
                + "','" + t.Header.Replace("'", "`") + "','" + t.Body.Replace("'", "`") + "','" + t.Worker.Replace("'", "`") + "'," + t.IsDone.ToString() + ");";
            Execute(sql);
        }
        public void UpdateTask(Task t, string tableName)
        {
            Loader();
            string SQL = "UPDATE " + tableName + " SET TargetDate='"+t.Date.ToShortDateString()+
                "' , Header='" + t.Header.Replace("'", "`") + "' , Body='" + t.Body.Replace("'", "`")
                + "' , Worker='" + t.Worker.Replace("'", "`")
                +"' , IsDone="+t.IsDone.ToString()+" WHERE ID="+t.ID.ToString()+";";
            Execute(SQL);
        }
        public Task SelectById(string tableName, long id)
        { 
            string SQL = "SELECT * FROM "+tableName+" WHERE ID="+id.ToString()+" ;";
            Reader = Execute(SQL);
            Reader.Read();
                Task temp;
                temp=new Task();
              //DO IT
                temp.Body = Reader.GetValue(Reader.GetOrdinal("Body")).ToString();
                temp.Header  = Reader.GetValue(Reader.GetOrdinal("Header")).ToString();
                temp.Worker = Reader.GetValue(Reader.GetOrdinal("Worker")).ToString();
                temp.ID =Convert.ToInt64( Reader.GetValue(Reader.GetOrdinal("ID")));
                temp.IsDone =(bool) Reader.GetValue(Reader.GetOrdinal("IsDone"));
                temp.Date =Convert.ToDateTime( Reader.GetValue(Reader.GetOrdinal("TargetDate")));
                return temp;
        }
        public Angar SelectByDate(string tableName, DateTime dt)
        {
            Loader();
            string SQL = "SELECT * FROM " + tableName + " WHERE TargetDate='" + dt.ToShortDateString() + "';";
            Angar answer;
            answer = new Angar();
            Reader = Execute(SQL);
                 while (Reader.Read())
                {
                    Task temp;
                    temp = new Task();
                    //DO IT
                    temp.Body = Reader.GetValue(Reader.GetOrdinal("Body")).ToString();
                    temp.Header = Reader.GetValue(Reader.GetOrdinal("Header")).ToString();
                    temp.Worker = Reader.GetValue(Reader.GetOrdinal("Worker")).ToString();
                    temp.ID = Convert.ToInt64(Reader.GetValue(Reader.GetOrdinal("ID")));
                    temp.IsDone = (bool)Reader.GetValue(Reader.GetOrdinal("IsDone"));
                    temp.Date = Convert.ToDateTime(Reader.GetValue(Reader.GetOrdinal("TargetDate")));
                    answer.Storage.Add(temp);
                }
            return answer;
        }
        public void DeleteTask(string tableName, Task t)
        {
            Loader();
            string sql = "DELETE FROM "+tableName+" WHERE ID="+t.ID.ToString()+";";
            Execute(sql);
        }
        public void DeleteAllTask(string tableName)//Delete all tasks
        {
            Loader();
            string sql = "DELETE FROM " + tableName + ";";
            Execute(sql);
        }
        public Angar SelectTask(string tableName, string columnName, string value, string comma)//Select by specific column and value
        {
            Loader();
            string SQL = "SELECT * FROM " + tableName + " WHERE "+columnName+"=" +comma+ value +comma+ ";";
            Angar answer;
            answer = new Angar();
            Reader = Execute(SQL);
            while (Reader.Read())
            {
                Task temp;
                temp = new Task();
                //DO IT
                temp.Body = Reader.GetValue(Reader.GetOrdinal("Body")).ToString();
                temp.Header = Reader.GetValue(Reader.GetOrdinal("Header")).ToString();
                temp.Worker = Reader.GetValue(Reader.GetOrdinal("Worker")).ToString();
                temp.ID = Convert.ToInt64(Reader.GetValue(Reader.GetOrdinal("ID")));
                temp.IsDone = (bool)Reader.GetValue(Reader.GetOrdinal("IsDone"));
                temp.Date = Convert.ToDateTime(Reader.GetValue(Reader.GetOrdinal("TargetDate")));
                answer.Storage.Add(temp);
            }
            return answer;
        }
    }
    public class Task
    {
        long _id;
        string _worker, _body, _header;
        DateTime _Date;
        bool _isdone;
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Worker
        {
            get { return _worker; }
            set { _worker = value; }
        }
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public bool IsDone
        {
            get { return _isdone; }
            set { _isdone = value; }
        }
        public object[] ToValues()
        {
            object[] a;
            a = new object[6];
            a[0] = ID;
            a[1] = Date;
            a[2] = Header ;
            a[3] = Body;
            a[4] = Worker;
            a[5] = IsDone;
            return a;
        }
    }
    class Angar
    {
        System.Collections.ObjectModel.Collection<Task> Array;
        public Angar()
        {
            Array=new System.Collections.ObjectModel.Collection<Task>();
        }
        public System.Collections.ObjectModel.Collection<Task> Storage
        {
            get { return Array; }
            set { Array = value; }
        }
        public static Angar  operator + (Task obj,Angar obj2)
        {
            obj2.Storage.Add(obj);
            return obj2;
        }
       
    }
