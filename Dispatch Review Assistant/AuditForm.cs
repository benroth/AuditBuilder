using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;

namespace AuditBuilder
{
    class AuditForm
    {
        public List<string> GrabAuditTypes(string sqlLocation)
        {
            SqlCeConnection myConnection = new SqlCeConnection(sqlLocation);
            myConnection.Open();
            List<string> radios = new List<string>();
            using (SqlCeCommand myCommand = new SqlCeCommand("SELECT DISTINCT AuditType FROM AuditTypes", myConnection))
            {
                SqlCeDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                    radios.Add(reader.GetString(0));
                myConnection.Close();                
            }
            return radios;
        }

        public List<AuditSelection> GrabAudit(string sqlLocation, string auditType)
        {
            List<AuditSelection> auditSelections = new List<AuditSelection>();
            SqlCeConnection myConnection = new SqlCeConnection(sqlLocation);
            myConnection.Open();

            using (SqlCeCommand myCommand = new SqlCeCommand("SELECT * FROM CheckBoxes JOIN AuditTypes ON CheckBoxes.checkID=AuditTypes.checkID WHERE auditType='" + auditType + "'", myConnection))
            {
                SqlCeDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    AuditSelection choice = new AuditSelection();
                    choice.checkID = reader.GetInt32(0);
                    choice.checkLabel = reader.GetString(1);
                    choice.checkToolTip = reader.GetString(2);
                    choice.checkValidState = reader.GetString(3);
                    choice.checkAuditText = reader.GetString(4);
                    auditSelections.Add(choice);
                }
                myConnection.Close();
            }
            return auditSelections;
        }        
    }

    class AuditSelection
    {
        public int checkID { get; set; }
        public string checkLabel { get; set; }
        public string checkToolTip { get; set; }
        public string checkValidState { get; set; }
        public string checkAuditText { get; set; }
    }
}
