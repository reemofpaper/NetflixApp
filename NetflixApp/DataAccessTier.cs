﻿// Data Access Tier:  interface between business tier and data store.

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessTier
{
  public class Data
  {
    //
    // Fields:
    //
    private string _DBFile;
    private string _DBConnectionInfo;

    //
    // constructor:
    //
    public Data(string DatabaseFilename)
    {
      string version;

      //version = "v11.0";    // for VS 2013:
      version = "MSSQLLocalDB";  // for VS 2015 and newer:

      _DBFile = DatabaseFilename;
      _DBConnectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;",
      version,
      DatabaseFilename);
    }

    //
    // TestConnection:  returns true if the database can be successfully opened and closed,
    // false if not.
    //
    public bool TestConnection()
    {
      SqlConnection db = new SqlConnection(_DBConnectionInfo);
      bool   state = false;
      try
      {
        db.Open();

        state = (db.State == ConnectionState.Open);
      }
      catch
      {
        // nothing, just discard:
      }
      finally
      {
        db.Close();
      }

      return state;
    }

    //
    // ExecuteScalarQuery:  executes a scalar Select query, returning the single result 
    // as an object.  
    //
    public object ExecuteScalarQuery(string sql)
    {
      SqlConnection db = new SqlConnection(_DBConnectionInfo);
      db.Open();
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = db;
      cmd.CommandText = sql;
      object result = cmd.ExecuteScalar();
      db.Close();
      return result;
    }

   
    // ExecuteNonScalarQuery:  executes a Select query that generates a temporary table,
    // returning this table in the form of a Dataset.

    public DataSet ExecuteNonScalarQuery(string sql)
    {
      SqlConnection db = new SqlConnection(_DBConnectionInfo);
      db.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = db;

      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      DataSet ds = new DataSet();

      cmd.CommandText = sql;
      adapter.Fill(ds);

      db.Close(); 
      
      return ds;
    }

    //
    // ExecutionActionQuery:  executes an Insert, Update or Delete query, and returns
    // the number of records modified.
    //
    public int ExecuteActionQuery(string sql)
    {
      SqlConnection db = new SqlConnection(_DBConnectionInfo);
      db.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = db;
      cmd.CommandText = sql;

      int rowsModified = cmd.ExecuteNonQuery();
      
      return rowsModified;
    }

  }//class

}//namespace
