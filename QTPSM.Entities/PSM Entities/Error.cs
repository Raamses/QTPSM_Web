using System;

namespace QTPSM.Entities
{
    public class Error : IEntityBase
    {
        public int id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}