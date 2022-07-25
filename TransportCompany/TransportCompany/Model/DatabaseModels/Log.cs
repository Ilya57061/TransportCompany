
using System.ComponentModel.DataAnnotations.Schema;


namespace TransportCompany.Model.DatabaseModels
{
    [Table("Logs")]
    public class Log
    {
        public int Id { get; set; }
        public DateTime Authorization { get; set; }
        public string UserName { get; set; }
    }
}
