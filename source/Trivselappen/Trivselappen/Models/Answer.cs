using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivselappen.Models
{
    public class Answer
    {
        public DateTime Timestamp { get; set; }
        public string DeviceId { get; set; }
        public int QuestionId { get; set; }
        public decimal Value { get; set; }
        public Position Position { get; set; }
    }
}
