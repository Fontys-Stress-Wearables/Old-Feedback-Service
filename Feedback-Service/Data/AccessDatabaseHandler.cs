using Feedback_Service.Models;
using System.Data;
using System.Data.OleDb;

namespace Feedback_Service.Data
{
    public class AccessDatabaseHandler : IDatabaseHandler
    {
        OleDbConnection connection;

        public AccessDatabaseHandler()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data/FeedbackDatabase.accdb");
        }

        public void AddFeedbackEntry(FeedbackEntry entry)
        {
            OleDbCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "Insert into FeedbackEntries(Id, AuthorId,StressMeasurementId,PatientId,Feedback)Values('" + entry.Id + "','" + entry.AuthorId + "','" + entry.StressMeasurementId + "','" + entry.PatientId + "','" + entry.Feedback + "')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<FeedbackEntry> GetAllForPatient(Guid patient)
        {
            List<FeedbackEntry> feedbackEntries = new List<FeedbackEntry>();

            string query = "SELECT * FROM FeedbackEntries WHERE PatientId=" + "'" + patient + "'" + ";";

            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            while (reader.Read())
            {
                Guid id = Guid.Parse(reader.GetString(0));
                Guid authorId = Guid.Parse(reader.GetString(1));
                Guid stressMeasurementId = Guid.Parse(reader.GetString(2));
                Guid patientId = Guid.Parse(reader.GetString(3));
                string feedback = reader.GetString(4);
                FeedbackEntry entry = new FeedbackEntry(id, authorId, stressMeasurementId, patientId, feedback);
                feedbackEntries.Add(entry);
            }
            connection.Close();

            return feedbackEntries;
        }

        public FeedbackEntry GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
