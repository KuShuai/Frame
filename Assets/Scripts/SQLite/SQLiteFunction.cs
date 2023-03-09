using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mono.Data.Sqlite;
using UnityEngine;

public class SQLiteFunction
{
    /// <summary>
    /// ������ȡ���ݿ��е�����, ��ѯ����
    /// </summary>
    private static SqliteDataReader _reader;

    private static StringBuilder _stringBuilder = new StringBuilder(1024);

    private static Dictionary<string, SqliteInfo> sqlite_dic_info = new Dictionary<string, SqliteInfo>();


    class SqliteInfo
    {
        private string _sqliteName;
        public string SqliteName { get { return _sqliteName; } }

        private string _sqlitePath;
        public string SqlitePath { get { return _sqlitePath; } }

        private SqliteConnection _sqliteConnection;
        private SqliteCommand _sqliteCommand;

        public SqliteCommand Command
        {
            get
            {
                if (_sqliteCommand == null && Connection != null)
                {
                    _sqliteCommand = Connection.CreateCommand();
                }
                return _sqliteCommand;
            }
        }

        public SqliteConnection Connection
        {
            get
            {
                if (_sqliteConnection == null && !string.IsNullOrEmpty(_sqlitePath))
                {
                    _sqliteConnection = new SqliteConnection(_sqlitePath);
                    _sqliteConnection.Open();
                }
                return _sqliteConnection;
            }
        }

        public SqliteInfo(string sqliteName, string sqlitePath = "")
        {
            _sqliteName = sqliteName;
            _sqlitePath = "Data Source = "+ (sqlitePath == "" ? Application.streamingAssetsPath + "/Sqlite/" + _sqliteName + ".sqlite" : sqlitePath);

        }
    }

    /// <summary>
    /// ��ӡ�����sqlite���ݿ�����
    /// </summary>
    /// <param name="sqliteName">���ݿ�����</param>
    /// <param name="sqlitePath">���ݿ�·��</param>
    public static void CreateSQLiteConnection(string sqliteName, string sqlitePath = "")
    {
        _stringBuilder.Clear();
        if (string.IsNullOrEmpty(sqlitePath))
        {
            sqlitePath = "Data Source = " + Application.streamingAssetsPath + "/Sqlite/{0}.sqlite";
        }

        sqlitePath = _stringBuilder.AppendFormat(sqlitePath, sqliteName).ToString();
        GetSqliteInfo(sqliteName, sqlitePath);
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="tableName">����</param>
    /// <param name="keysName">�ֶ�</param>
    /// <param name="keysType">�ֶεĸ�����Ϣ type  ��primary key��</param>
    /// <returns></returns>
    public static bool CreateOperation(string sqliteName,string tableName, object[] keysName ,object[] keysType)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat("create table if not exists {0}", tableName);
        _stringBuilder.Append("(");
        for (int i = 0; i < keysName.Length; i++)
        {
            if (i != 0)
            {
                _stringBuilder.Append(",");
            }
            _stringBuilder.Append(keysName[i]+" "+keysType[i]);
        }
        _stringBuilder.Append(")");

        return ExecuteNonQuery(sqliteName, _stringBuilder.ToString());
    }

    /// <summary>
    /// ��
    /// </summary>
    /// <param name="tableName">����</param>
    /// <param name="keysName">keyֵ</param>
    /// <param name="values">��Ӧ��valueֵ</param>
    /// <returns></returns>
    public static bool InsertOperation(string sqliteName, string tableName,object[] keysName,object[] values)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat("insert into {0} (", tableName);
        for (int i = 0; i < keysName.Length; i++)
        {
            if (i != 0)
            {
                _stringBuilder.Append(",");
            }
            _stringBuilder.Append(keysName[i]);
        }
        _stringBuilder.Append(") values(");
        for (int i = 0; i < values.Length; i++)
        {
            if (i != 0)
            {
                _stringBuilder.Append(",");
            }
            _stringBuilder.Append(values[i]);
        }
        _stringBuilder.Append(")");

        return ExecuteNonQuery(sqliteName,_stringBuilder.ToString());
    }

    /// <summary>
    /// ɾ
    /// </summary>
    /// <param name="tableName">����</param>
    /// <param name="key">keyֵ</param>
    /// <param name="value">value</param>
    /// <returns></returns>
    public static bool DeleteOperation(string sqliteName,string tableName, Dictionary<string, string> conditions)
    {
        _stringBuilder.Clear();
        string condition = string.Empty;
        foreach (var item in conditions)
        {
            if (!string.IsNullOrEmpty(condition))
            {
                condition += ",";
            }
            condition += item.Key + "=" + item.Value;
        }
        _stringBuilder.AppendFormat("delete form {0} where {1}", tableName, condition);

        return ExecuteNonQuery(sqliteName, _stringBuilder.ToString());
    }

    /// <summary>
    /// ��
    /// </summary>
    /// <param name="tableName">����</param>
    /// <param name="columns">�޸�����</param>
    /// <param name="condition">�޸�����</param>
    /// <returns></returns>
    public static bool UpdateOperation(string sqliteName,string tableName, Dictionary<string, string> columns, Dictionary<string, string> conditions)
    {
        _stringBuilder.Clear();
        string column = "";
        foreach (var item in columns)
        {
            if (!string.IsNullOrEmpty(column))
            {
                column += ",";
            }
            column += item.Key + " = " + item.Value;
        }
        string condition = string.Empty;
        foreach (var item in conditions)
        {
            if (!string.IsNullOrEmpty(condition))
            {
                condition += ",";
            }
            condition += item.Key + " = " + item.Value;
        }
        _stringBuilder.AppendFormat("update {0} set {1} where {2}", tableName, column, condition);
        return ExecuteNonQuery(sqliteName, _stringBuilder.ToString());
    }

    /// <summary>
    /// ��ѯ���ݿ������ֶ���Ϣ
    /// </summary>
    /// <param name="sqliteName">���ݿ�</param>
    /// <param name="tableName">��</param>
    /// <returns></returns>
    public static string SelectOperation(string sqliteName,string tableName,out object[] keyVlaue)
    {
        keyVlaue = null;
        SqliteInfo sqliteInfo = GetSqliteInfo(sqliteName);
        if (sqliteInfo == null)
        {
            Debug.LogError("sqlit is not exist! ");
            return string.Empty;
        }
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat("pragma table_info ({0})", tableName);
        try
        {
            sqliteInfo.Command.CommandText = _stringBuilder.ToString();

            _stringBuilder.Clear();
            _reader = sqliteInfo.Command.ExecuteReader();
            List<object> key = new List<object>();
            while (_reader.Read())
            {
                key.Add(_reader.GetValue(1));
                string value = _reader.GetValue(1).ToString();
                object type = _reader.GetValue(2).ToString();

                if (_stringBuilder.Length != 0)
                {
                    _stringBuilder.Append("|");
                }
                _stringBuilder.Append(value).Append(":").Append(type);
            }
            _reader.Close();
            keyVlaue = key.ToArray();
        }
        catch (SqliteException e)
        {
            Debug.LogErrorFormat("sqlite ���ִ�д��� e �� {0}�� commandText : {1};", e, sqliteInfo.Command.CommandText);
        }
        return _stringBuilder.ToString();
    }

    /// <summary>
    /// ��
    /// </summary>
    /// <param name="sqliteName">���ݿ���</param>
    /// <param name="tableName">����</param>
    /// <param name="conditions">���� key = value</param>
    /// <param name="columns">��ѯ��</param>
    /// <returns></returns>
    public static string SelectOperation(string sqliteName, string tableName, Dictionary<string, string> conditions, params string[] columns)
    {
        List<string> cons = new List<string>();
        foreach (var item in conditions)
        {
            cons.Add(item.Key + " = " + item.Value);
        }
        return SelectOperation(sqliteName, tableName, cons, columns);
    }

    /// <summary>
    /// ��
    /// </summary>
    /// <param name="sqliteName">���ݿ���</param>
    /// <param name="tableName">����</param>
    /// <param name="conditions">��ѯ�ĸ�������</param>
    /// <param name="columns">��ѯ��</param>
    /// <returns></returns>
    public static string SelectOperation(string sqliteName,string tableName,List<string> conditions ,params string[] columns)
    {
        SqliteInfo sqliteInfo = GetSqliteInfo(sqliteName);

        if (sqliteInfo == null)
        {
            Debug.LogError("sqlit is not exist! ");
            return string.Empty;
        }
        //SELECT column1, column2, columnN FROM table_name;
        string condition = string.Empty;
        if (conditions.Count > 0)
        {
            _stringBuilder.Clear();
            for (int i = 0; i < conditions.Count; i++)
            {
                if (!string.IsNullOrEmpty(condition))
                {
                    condition += ",";
                }
                condition += conditions[i];
            }
        }

        string column = string.Empty;
        for (int i = 0; i < columns.Length; i++)
        {
            if (!string.IsNullOrEmpty(column))
            {
                column += ",";
            }
            column += columns[i];
        }
        _stringBuilder.AppendFormat("SELECT {0} FROM {1} {2}", column, tableName, condition.Length == 0? "" : string.Format("WHERE {0}", condition));
        try
        {
            sqliteInfo.Command.CommandText = _stringBuilder.ToString();

            _stringBuilder.Clear();
            _reader = sqliteInfo.Command.ExecuteReader();
            while (_reader.Read())
            {
                for (int i = 0; i < _reader.FieldCount; i++)
                {
                    string key = _reader.GetName(i);
                    object value = _reader.GetValue(i);
                    if (_stringBuilder.Length != 0)
                    {
                        _stringBuilder.Append("|");
                    }
                    _stringBuilder.Append(key).Append(":").Append(value);
                }
            }
            _reader.Close();
        }
        catch (SqliteException e)
        {
            Debug.LogError("��ѯ���� e��" + e.Message + "sql commandtext :" + sqliteInfo.Command.CommandText);
        }
        return _stringBuilder.ToString();
    }

    /// <summary>
    /// ִ�зǲ�ѯ���
    /// </summary>
    public static bool ExecuteNonQuery(string sqliteName, string format, params object[] args)
    {
        SqliteInfo sqliteInfo = GetSqliteInfo(sqliteName);

        if (sqliteInfo == null)
        {
            Debug.LogError("sqlit is not exist! ");
            return false;
        }

        _stringBuilder.Clear();
        _stringBuilder.AppendFormat(format, args);
        sqliteInfo.Command.CommandText = _stringBuilder.ToString();
        try
        {
            sqliteInfo.Command.ExecuteNonQuery();
        }
        catch (SqliteException e)
        {
            Debug.LogErrorFormat("���ݿ�������� {0}", e.Message);
            return false;
        }
        return true;
    }

    private static SqliteInfo GetSqliteInfo(string sqliteName,string sqlitePath = "")
    {
        SqliteInfo rt = null;
        sqlite_dic_info.TryGetValue(sqliteName, out rt);
        if (rt == null)
        {
            if (sqlitePath != "")
            {
                sqlitePath = _stringBuilder.AppendFormat(sqlitePath, sqliteName).ToString();
            }
            rt = new SqliteInfo(sqliteName, sqlitePath);
            sqlite_dic_info.Add(sqliteName, rt);
        }
        return rt;
    }
}